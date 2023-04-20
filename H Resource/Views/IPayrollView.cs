using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Views
{
    public interface IPayrollView
    {
        public string SearchValue { get; set; }
        public string? SearchCriteria { get; }
        public bool IsCached { get; set; }

        void SetPayrollsBindingSource(BindingSource payrolls);
        //Events
        event EventHandler SearchEvent;
        event EventHandler<EventArgs> ShowHomeView;

        void Show();
        void Close();
    }
}
