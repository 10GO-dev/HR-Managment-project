using H_Resource.Models;
using H_Resource.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource._Repositories
{
    public interface IVacationRepository
    {
        Task<IEnumerable<VacationEmployeeList>> GetAllAsync();
        Task AddAsync(VacationModel vacation);
        Task EditAsync(VacationModel vacation);
        Task DeleteAsync(VacationModel vacation);
        Task<IEnumerable<VacationEmployeeList>> FindByValueAsync(string value);


       
    }
}
