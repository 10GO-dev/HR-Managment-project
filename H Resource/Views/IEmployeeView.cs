using H_Resource.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Views
{
    public interface IEmployeeView
    {
        //Propoerties - Fields

        string Message { get; set; }
        public string SearchValue { get; set; }
        public string? SearchCriteria { get; }
        public bool IsCached { get; set; }

        public int SelectedEmployeeIndex { get; }


        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler CancelEvent;

        event EventHandler OnEmployeeDeleted;
        event EventHandler OnEmployeeAdded;
        event EventHandler OnEmployeeUpdated;

        event EventHandler<EventArgs> ShowHomeView;
        event EventHandler<EventArgs> ShowAddOrEditView;

        //Methods
        void SetEmployeeListBindingSource(BindingSource employeeList);
        void Show();//Opcional
        void Close();
        void Hide();
    }
}
