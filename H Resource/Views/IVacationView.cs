using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Views
{
    public interface IVacationView
    {
        //Properties - Fields
        public string FullName { get; set; }
        public string Department { get; set; }
        public string DocumentId { get; set; }
        DateTime? HireDate { get; set; }
        public string AvailableDays { get; set; }
        public string? TakenDays { get; set; }
        public Image? Image { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public string SearchValue { get; set; }
        public string SearchType { get; set; }
        public string SearchValueType { get; set;}
        public bool IsCached { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler RemoveEvent;
        event EventHandler EditEvent;
        event EventHandler SelectEmployeeClick;
        event EventHandler<EventArgs> ShowHomeView;
        void Show();
        void Close();

        void SetVacationListBindingSource(BindingSource vacationList);
        void SetEmployeeDetailBindingSource(BindingSource employeeDetail);

    }
}
