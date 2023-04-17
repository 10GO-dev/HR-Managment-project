using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Models
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
