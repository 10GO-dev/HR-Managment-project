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
        void Add(Employee employeeModel);
        void Edit(Employee employeeModel);
        void Delete(Employee employeeModel);
        void Update(Employee employeeModel);
        IEnumerable<Employee> GetAll();
        IEnumerable<Employee> FindByValue();

    }
}
