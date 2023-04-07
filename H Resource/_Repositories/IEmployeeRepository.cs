using H_Resource.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource._Repositories
{
    internal interface IEmployeeRepository
    {
        void Add(EmployeeModel employeeModel);
        void Edit(EmployeeModel employeeModel);
        void Delete(EmployeeModel employeeModel);
        void Update(EmployeeModel employeeModel);
        IEnumerable<EmployeeModel> GetAll();
        IEnumerable<EmployeeModel> FindByValue();

    }
}
