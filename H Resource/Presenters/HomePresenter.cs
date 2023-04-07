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
        private IHomeView view;

        public HomePresenter(IHomeView view)
        {
            this.view = view;
            //Show view
            this.view.Show();
        }
    }
}
