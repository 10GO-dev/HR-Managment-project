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
            using (HrmsDbContext dbContext = new HrmsDbContext())
            {
                employeeList = await DbContext.Employees.AsNoTracking().Include(e => e.Gender).Include(e => e.Department).Include(e => e.Country).ToListAsync();
                dbContext.ChangeTracker.Clear();
            }
            return employeeList;
        }

        public async Task<IEnumerable<EmployeeModel>> FindByValueAsync(string criteria, string value)
        {
            var employeeList = new List<EmployeeModel>();
            using(HrmsDbContext dbContext = new HrmsDbContext())
            {
                switch (criteria)
                {
                    case "Nombre":
                        employeeList = await DbContext.Employees.Where(e => e.FirstName.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .ToListAsync();
                        break;
                    case "Apellido":
                        employeeList = await DbContext.Employees.Where(e => e.LastName.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .ToListAsync();
                        break;
                    case "Cédula":
                        employeeList = await DbContext.Employees.Where(e => e.DocumentId.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .ToListAsync();
                        break;
                    case "Correo":
                        employeeList = await DbContext.Employees.Where(e => e.Email.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .ToListAsync();
                        break;
                    case "Teléfono":
                        employeeList = await DbContext.Employees.Where(e => e.Phone.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
                                                        .ToListAsync();
                        break;
                    case "Departamento":
                        employeeList = await DbContext.Employees.Where(e => e.Department.DepartmentName.Contains(value))
                                                        .Include(e => e.Gender)
                                                        .Include(e => e.Department)
                                                        .Include(e => e.Country)
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
            EmployeeModel? employee = DbContext.Employees.AsNoTracking().SingleOrDefault(e => e.EmployeeId == id);
            return employee;
        }

        public async Task AddAsync(EmployeeModel employee)
        {
            DbContext.Employees.Add(employee);
            await DbContext.SaveChangesAsync();
            DbContext.ChangeTracker.Clear();

        }

        public async Task EditAsync(EmployeeModel employee)
        {
                DbContext.Employees.Entry(employee).State = EntityState.Modified;
                await DbContext.SaveChangesAsync();
                DbContext.ChangeTracker.Clear();
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
