using H_Resource.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource._Repositories
{
    public class PayrollRepository : BaseRepository, IPayrollRepository
    {
        public async Task<IEnumerable<PayrollModel>> FindByValueAsync(string criteria, string value)
        {
            var payrollList = new List<PayrollModel>();
            using (HrmsDbContext dbContext = new HrmsDbContext())
            {
                switch (criteria)
                {
                    case "Nombre":
                        payrollList = await dbContext.Payrolls.AsNoTracking().Include(e => e.Employee).ThenInclude(e => e.Department).Where(e => e.Employee.FirstName == value).ToListAsync();
                        break;
                    
                    case "Apellido":
                        payrollList = await dbContext.Payrolls.AsNoTracking().Include(e => e.Employee).ThenInclude(e => e.Department).Where(e => e.Employee.LastName == value).ToListAsync();
                        break;
                    
                    case "Departamento":
                        payrollList = await dbContext.Payrolls.AsNoTracking().Include(e => e.Employee).ThenInclude(e => e.Department).Where(e => e.Employee.Department.DepartmentName == value).ToListAsync();
                        break;
                }
            }
            return payrollList;
        }

        public async Task<IEnumerable<PayrollModel?>> GetAllAsync()
        {
            var payrolList = new List<PayrollModel>();
            using (HrmsDbContext dbContext = new HrmsDbContext())
            {
                payrolList = await dbContext.Payrolls.AsNoTracking().Include(e => e.Employee).ThenInclude(e => e.Department).ToListAsync();
                dbContext.ChangeTracker.Clear();
            }
            return payrolList;
        }

        public PayrollModel? GetAsync(int id)
        {
            PayrollModel? payroll = DbContext.Payrolls.AsNoTracking().Include(e => e.Employee).ThenInclude(e => e.Department).FirstOrDefault(e => e.PayrollId == id);

            return payroll;
        }
    }
}
