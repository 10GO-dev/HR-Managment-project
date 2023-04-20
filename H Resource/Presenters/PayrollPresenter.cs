using H_Resource._Repositories;
using H_Resource.Models;
using H_Resource.Models.Request;
using H_Resource.Views;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Presenters
{
    public class PayrollPresenter
    {
        //Fields
        private readonly IPayrollView _view;
        private IPayrollRepository repository;
        private BindingSource PayrollsBindingSource;
        private static IEnumerable<PayrollModel> payrollList;

        public PayrollPresenter(IPayrollView view, IPayrollRepository repository)
        {
            PayrollsBindingSource = new BindingSource();
            _view = view;
            this.repository = repository;
            _view.SetPayrollsBindingSource(PayrollsBindingSource);
            _view.ShowHomeView += ShowHomeView;
            _view.SearchEvent += SearchEvent;
            LoadAllPayrolls();
            _view.Show();
        }

        private async void SearchEvent(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            bool emptyCriteria = string.IsNullOrWhiteSpace(this._view.SearchCriteria);
            if (!emptyValue && !emptyCriteria)
            {
                payrollList = await repository.FindByValueAsync(this._view.SearchCriteria, this._view.SearchValue);

            }
            List<EmployeePayrollModel> employeePayrollList = payrollList.Select(e => new EmployeePayrollModel
            {
                FullName = e.Employee.FirstName + " " + e.Employee.LastName,
                Department = e.Employee.Department.DepartmentName,
                BaseSalary = e.BaseSalary,
                Deductions = e.Deductions,
                Perks = e.Perks,
                NetoSalary = e.BaseSalary - e.Deductions + e.Perks,
            }).ToList();
            PayrollsBindingSource.DataSource = employeePayrollList;
        }

        private void ShowHomeView(object? sender, EventArgs e)
        {
            MainContainer mainContainer = MainContainer.GetInstance();
            IHomeView view = HomeView.GetInstance(mainContainer);
            mainContainer.AddView((Form)view);
            new HomePresenter(view);
            this._view.Close();
        }

        private async void LoadAllPayrolls()
        {
            if(payrollList == null)
            {
                payrollList = await repository.GetAllAsync();
            }
            List<EmployeePayrollModel> employeePayrollList = payrollList.Select(e => new EmployeePayrollModel
            {
                FullName = e.Employee.FirstName +" "+e.Employee.LastName,
                Department = e.Employee.Department.DepartmentName,
                BaseSalary = e.BaseSalary,
                Deductions = e.Deductions,
                Perks = e.Perks,
                NetoSalary = e.BaseSalary - e.Deductions + e.Perks,
            }).ToList();
            PayrollsBindingSource.DataSource = employeePayrollList;
        }
    }
}
