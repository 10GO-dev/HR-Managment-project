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
        public int? VacationID { get; set; }
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string DocumentId { get; set; }
        DateTime? HireDate { get; set; }
        public string AvailableDays { get; set; }
        public string? TakenDays { get; set; }
        public Image? Image { get; set; }
        public bool IsEdit { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }


        public string SearchValue { get; set; }
        public string SearchType { get; set; }
        public string SearchValueType { get; set;}
        public bool IsCached { get; set; }

        public int SelectedEmployeeIndex { get;}
        public int SelectedVacationIndex { get;}


        //Events
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler SaveEvent;
        event EventHandler EditEvent;
        event EventHandler SelectEmployeeClick;
        event EventHandler<EventArgs> ShowHomeView;
        void Show();
        void Close();
        void ResetTabVacationEdit();

        void SetVacationListBindingSource(BindingSource vacationList);
        void SetEmployeeDetailBindingSource(BindingSource employeeDetail);
        void GoBack();

    }
}
