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
    internal interface IEmployeeView
    {
        //Propoerties - Fields
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? GenderId { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[]? Image { get; set; }
        public DateTime? HireDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? CountryId { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetEmployeeListBindingSource(BindingSource employeeList);
        void Show();//Opcional
    }
}
