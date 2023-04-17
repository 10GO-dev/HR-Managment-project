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
            //Show view
            this.homeView.Show();
        }

        private void ShowEmployeeView(object? sender, EventArgs e)
        {
            MainContainer container = MainContainer.GetInstance();
            EmployeeView view = EmployeeView.GetInstance(container);
            //HrmsDbContext db = new HrmsDbContext();
            EmployeeRepository repository = new EmployeeRepository();
            container.AddView(view);
            new EmployeePresenter(view, repository);
            this.homeView.Close();
        }
    }
}
