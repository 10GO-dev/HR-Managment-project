using Dapper;
using H_Resource.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource._Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository, IDisposable
    {
        private readonly IMemoryCache _cache;
        //Constructor
        public EmployeeRepository()
        {

        }

        //Methods
        public async Task<IEnumerable<EmployeeModel>> GetAllAsync()
        {
            var employeeList = new List<EmployeeModel>();
            try
            {
                using (HrmsDbContext dbContext = new HrmsDbContext())
                {
                    employeeList = await DbContext.Employees.AsNoTracking().Include(e => e.Gender).Include(e => e.Department).Include(e => e.Country).Include(e => e.Payrolls).ToListAsync();
                    dbContext.ChangeTracker.Clear();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return employeeList;
        }

        public async Task<IEnumerable<EmployeeModel>> FindByValueAsync(string criteria, string value)
        {
            var employeeList = new List<EmployeeModel>();
            using (HrmsDbContext dbContext = new HrmsDbContext())
            {
                switch (criteria)
                {
                    case "Nombre":
                        employeeList = await DbContext.Employees.Where(e => e.FirstName.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .Include(e => e.Payrolls)
                                                        .ToListAsync();
                        break;
                    case "Apellido":
                        employeeList = await DbContext.Employees.Where(e => e.LastName.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .Include(e => e.Payrolls)
                                                        .ToListAsync();
                        break;
                    case "Cédula":
                        employeeList = await DbContext.Employees.Where(e => e.DocumentId.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .Include(e => e.Payrolls)
                                                        .ToListAsync();
                        break;
                    case "Correo":
                        employeeList = await DbContext.Employees.Where(e => e.Email.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .Include(e => e.Payrolls)
                                                        .ToListAsync();
                        break;
                    case "Teléfono":
                        employeeList = await DbContext.Employees.Where(e => e.Phone.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .Include(e => e.Payrolls)
                                                        .ToListAsync();
                        break;
                    case "Departamento":
                        employeeList = await DbContext.Employees.Where(e => e.Department.DepartmentName.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .Include(e => e.Payrolls)
                                                        .ToListAsync();
                        break;
                }
                dbContext.ChangeTracker.Clear();
            }
            DbContext.ChangeTracker.Clear();
            return employeeList;
        }

        public EmployeeModel? GetAsync(int id)
        {
            EmployeeModel? employee = DbContext.Employees.AsNoTracking().Include(e => e.Department).Include(e => e.Gender).Include(e => e.Country).Include(e => e.Payrolls).FirstOrDefault(e => e.EmployeeId == id);

            return employee;
        }

        public async Task AddAsync(EmployeeModel employee)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Insertar el registro del empleado
                        var insertEmployeeQuery = @"
                    INSERT INTO Employees (FirstName, LastName, DocumentID, BirthDate, GenderID, MaritalStatus, Address, Phone, Email, Image, HireDate, DepartmentID, CountryID, AvailableDays)
                    VALUES (@FirstName, @LastName, @DocumentID, @BirthDate, @GenderID, @MaritalStatus, @Address, @Phone, @Email, @Image, @HireDate, @DepartmentID, @CountryID, @AvailableDays);

                    SELECT CAST(SCOPE_IDENTITY() AS INT);
                ";

                        var employeeId = await connection.ExecuteScalarAsync<int>(insertEmployeeQuery, employee, transaction);

                        // 2. Insertar la nómina del empleado
                        var baseSalary = employee.Payrolls.First().BaseSalary;
                        var deductions = baseSalary * 0.11m;
                        var perks = baseSalary * 0.05m;

                        var insertPayrollQuery = @"
                    INSERT INTO Payroll (EmployeeID, BaseSalary, Deductions, Perks, EntryDate)
                    VALUES ( @EmployeeID, @BaseSalary, @Deductions, @Perks, @EntryDate);
                ";

                        var payroll = new PayrollModel
                        {
                            EmployeeId = employeeId,
                            BaseSalary = baseSalary,
                            Deductions = deductions,
                            Perks = perks,
                            EntryDate = DateTime.Now.Date
                        };

                        await connection.ExecuteAsync(insertPayrollQuery, payroll, transaction);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }



        public async Task EditAsync(EmployeeModel employee)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();

                var transaction = connection.BeginTransaction();

                try
                {
                    // Actualizar el registro del empleado
                    await connection.ExecuteAsync(
                        "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, DocumentID = @DocumentID, BirthDate = @BirthDate, " +
                        "GenderID = @GenderID, MaritalStatus = @MaritalStatus, Address = @Address, Phone = @Phone, Email = @Email, " +
                        "Image = @Image, HireDate = @HireDate, DepartmentID = @DepartmentID, CountryID = @CountryID, AvailableDays = @AvailableDays " +
                        "WHERE EmployeeID = @EmployeeID",
                        new
                        {
                            employee.EmployeeId,
                            employee.FirstName,
                            employee.LastName,
                            employee.DocumentId,
                            employee.BirthDate,
                            employee.GenderId,
                            employee.MaritalStatus,
                            employee.Address,
                            employee.Phone,
                            employee.Email,
                            employee.Image,
                            employee.HireDate,
                            employee.DepartmentId,
                            employee.CountryId,
                            employee.AvailableDays
                        },
                        transaction);

                    // Calcular las deducciones y bonos de la nómina
                    var baseSalary = employee.Payrolls.First().BaseSalary;
                    var deductions = baseSalary * 0.11m;
                    var perks = baseSalary * 0.05m;

                    // Actualizar el registro de la nómina
                    await connection.ExecuteAsync(
                        "UPDATE Payroll SET BaseSalary = @BaseSalary, Deductions = @Deductions, Perks = @Perks " +
                        "WHERE EmployeeID = @EmployeeID",
                        new
                        {
                            employee.EmployeeId,
                            BaseSalary = baseSalary,
                            Deductions = deductions,
                            Perks = perks
                        },
                        transaction);

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Deshacer la transacción si hay algún error
                    transaction.Rollback();
                    throw new Exception("Error al editar el empleado y la nómina", ex);
                }
            }
        }


        public async Task DeleteAsync(EmployeeModel employee)
        {
            DbContext.Entry(employee).State = EntityState.Deleted;
            await DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}