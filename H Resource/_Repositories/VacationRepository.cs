using Dapper;
using H_Resource.Models;
using H_Resource.Models.Request;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource._Repositories
{
    internal class VacationRepository : BaseRepository, IVacationRepository
    {

        public VacationRepository() { }

        public async Task AddAsync(VacationModel vacation)
        {
            using IDbConnection db = new SqlConnection(ConnectionString);
            db.Open();

            IDbTransaction transaction = db.BeginTransaction();

            try
            {
                // Verificar que el empleado tiene suficientes días disponibles
                var employee = await db.QuerySingleOrDefaultAsync<EmployeeModel>(
                    "SELECT * FROM Employees WHERE EmployeeId = @EmployeeId", new { vacation.EmployeeId }, transaction);

                if (employee == null)
                {
                    throw new ArgumentException("Employee not found.");
                }

                if (employee.AvailableDays < vacation.TakenDays)
                {
                    throw new ArgumentException("Employee does not have enough available vacation days.");
                }

                // Insertar la nueva vacación
                string insertVacationQuery = @"
            INSERT INTO Vacations (EmployeeId, StartDate, EndDate, TakenDays)
            VALUES (@EmployeeId, @StartDate, @EndDate, @TakenDays);
            SELECT CAST(SCOPE_IDENTITY() as int);";

                int vacationId = await db.ExecuteScalarAsync<int>(
                    insertVacationQuery,
                    new
                    {
                        vacation.EmployeeId,
                        vacation.StartDate,
                        vacation.EndDate,
                        vacation.TakenDays
                    },
                    transaction);

                // Actualizar los días disponibles del empleado
                string updateEmployeeQuery = @"
            UPDATE Employees
            SET AvailableDays = AvailableDays - @TakenDays
            WHERE EmployeeId = @EmployeeId;";

                await db.ExecuteAsync(
                    updateEmployeeQuery,
                    new
                    {
                        vacation.TakenDays,
                        vacation.EmployeeId
                    },
                    transaction);

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }


        public async Task DeleteAsync(VacationModel vacation)
        {
            DbContext.Entry(vacation).State = EntityState.Deleted;
            await DbContext.SaveChangesAsync();
        }

        public async Task EditAsync(VacationModel vacation)
        {
            using IDbConnection db = new SqlConnection(ConnectionString);
            db.Open();

            string sqlUpdateVacation = @"
        UPDATE Vacations 
        SET StartDate = @StartDate, EndDate = @EndDate
        WHERE VacationID = @VacationID;
    ";

            await db.ExecuteAsync(sqlUpdateVacation, vacation);

            string updateEmployeeQuery = @"
            UPDATE Employees
            SET AvailableDays = AvailableDays - @TakenDays
            WHERE EmployeeId = @EmployeeId;";

            await db.ExecuteAsync(updateEmployeeQuery, new { TakenDays = vacation.TakenDays, EmployeeId = vacation.EmployeeId });
        }


        public async Task<IEnumerable<VacationEmployeeList>> FindByValueAsync(string value)
        {
            const string sql = @"
        SELECT
            v.VacationID,
            e.EmployeeId, 
            e.FirstName+' '+e.LastName as FullName, 
            d.DepartmentName as Department, 
            e.HireDate, 
            e.DocumentID, 
            e.Image,
            v.StartDate, 
            v.EndDate, 
            v.TakenDays, 
            e.AvailableDays
        FROM 
            Vacations AS v 
            JOIN Employees AS e ON v.EmployeeID = e.EmployeeID 
            JOIN Departments AS d ON e.DepartmentID = d.DepartmentID 
            JOIN Gender AS g ON e.GenderID = g.Id 
            JOIN Country AS c ON e.CountryID = c.Id
        WHERE 
            e.FirstName LIKE '%' + @value + '%'
            OR
            e.LastName LIKE '%' + @value + '%'
        ORDER BY 
            e.FirstName, 
            v.StartDate;
    ";
            using var connection = new SqlConnection(ConnectionString);
            await connection.OpenAsync();
            var result = await connection.QueryAsync<VacationEmployeeList>(sql, new { value });
            return result;
        }


        public async Task<IEnumerable<VacationEmployeeList>> GetAllAsync()
        {
            var query = @"
         SELECT 
            v.VacationID,
            e.EmployeeId, 
            e.FirstName+' '+e.LastName as FullName, 
            d.DepartmentName as Department, 
            e.HireDate, 
            e.DocumentID, 
            e.Image,
            v.StartDate, 
            v.EndDate, 
            v.TakenDays, 
            e.AvailableDays
        FROM 
            Vacations AS v 
            JOIN Employees AS e ON v.EmployeeID = e.EmployeeID 
            JOIN Departments AS d ON e.DepartmentID = d.DepartmentID 
            JOIN Gender AS g ON e.GenderID = g.Id 
            JOIN Country AS c ON e.CountryID = c.Id
        ORDER BY 
            e.FirstName, 
            v.StartDate;
    ";

            using (var connection = new SqlConnection(ConnectionString))
            {
                var vacationEmployeeList = await connection.QueryAsync<VacationEmployeeList>(query);
                return vacationEmployeeList;
            }
        }
    }
}
