using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H_Resource.Models;
using H_Resource.Models.Request;

namespace H_Resource._Repositories
{
    public interface IEmployeeRepository
    {
        Task AddAsync(EmployeeModel employee);
        Task EditAsync(EmployeeModel employee);
        Task DeleteAsync(EmployeeModel employee);
        Task<IEnumerable<EmployeeModel?>> GetAllAsync();
        Task<IEnumerable<EmployeeModel>> FindByValueAsync(string criteria, string value);
        EmployeeModel? GetAsync(int id);
    }
}
