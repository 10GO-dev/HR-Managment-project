using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Views
{
    public interface IMainContainer
    {
        event EventHandler<EventArgs> ShowHomeView;
        event EventHandler<EventArgs> ShowEmployeesView;
        void Show();

        public void AddView(Form view);
    }
}
