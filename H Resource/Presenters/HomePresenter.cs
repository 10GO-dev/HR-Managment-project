using H_Resource._Repositories;
using H_Resource.Models;
using H_Resource.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Presenters
{
    public class HomePresenter
    {
        //Fields
        private readonly IHomeView homeView;
       

        public HomePresenter(IHomeView view)
        {
            this.homeView = view;
            this.homeView.ShowEmployeesView += ShowEmployeeView;
            this.homeView.ShowVacationView += ShowVacationView;
            this.homeView.ShowPayrollView += ShowPayrollView;
            //Show view
            this.homeView.Show();
        }

        private void ShowVacationView(object? sender, EventArgs e)
        {
            MainContainer container = MainContainer.GetInstance();
            VacationView view = VacationView.GetInstance(container);
            EmployeeRepository EmployeeRepository = new EmployeeRepository();
            VacationRepository repository = new VacationRepository();
            container.AddView(view);
            new VacationPresenter(view, repository,EmployeeRepository);
            this.homeView.ShowEmployeesView -= ShowEmployeeView;
            this.homeView.ShowVacationView -= ShowVacationView;
            this.homeView.ShowPayrollView -= ShowPayrollView;
            this.homeView.Close();
        }

        private void ShowEmployeeView(object? sender, EventArgs e)
        {
            MainContainer container = MainContainer.GetInstance();
            EmployeeView view = EmployeeView.GetInstance(container);
            //HrmsDbContext db = new HrmsDbContext();
            EmployeeRepository repository = new EmployeeRepository();
            container.AddView(view);
            new EmployeePresenter(view, repository);
            this.homeView.ShowEmployeesView -= ShowEmployeeView;
            this.homeView.ShowVacationView -= ShowVacationView;
            this.homeView.ShowPayrollView -= ShowPayrollView;
            this.homeView.Close();
        }
        private void ShowPayrollView(object? sender, EventArgs e)
        {
            MainContainer container = MainContainer.GetInstance();
            PayrollView view = PayrollView.GetInstance(container);
            EmployeeRepository EmployeeRepository = new EmployeeRepository();
            PayrollRepository repository = new PayrollRepository();
            container.AddView(view);
            new PayrollPresenter(view, repository);
            this.homeView.ShowEmployeesView -= ShowEmployeeView;
            this.homeView.ShowVacationView -= ShowVacationView;
            this.homeView.ShowPayrollView -= ShowPayrollView;
            this.homeView.Close();
        }
    }
}
