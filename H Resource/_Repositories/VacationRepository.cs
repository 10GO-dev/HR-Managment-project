using Dapper;
using H_Resource.Models;
using H_Resource.Models.Request;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            DbContext.Vacations.Add(vacation);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(VacationModel vacation)
        {
            DbContext.Entry(vacation).State = EntityState.Deleted;
            await DbContext.SaveChangesAsync();
        }

        public async Task EditAsync(VacationModel vacation)
        {
            DbContext.Vacations.Entry(vacation).State = EntityState.Modified;
            await DbContext.SaveChangesAsync(); 
        }

        public async Task<IEnumerable<VacationEmployeeList>> FindByValueAsync(string value)
        {
            const string sql = @"
        SELECT 
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
