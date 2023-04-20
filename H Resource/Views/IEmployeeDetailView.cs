using H_Resource.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Views
{
    public interface IEmployeeDetailView
    {



        //Fields
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? GenderId { get; set; }
        public string? Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Image? Image { get; set; }
        public DateTime? HireDate { get; set; }
        public int? DepartmentId { get; set; }
        public string DocuemntId { get; set; }

        public int Salary { get;set; }
        public int? CountryId { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        bool IsEdit { get; set; }

        //Events
        event EventHandler<EventArgs> ShowHomeView;
        event EventHandler<EventArgs> ShowEmployeesView;
        event EventHandler SaveEvent; 
        event EventHandler CancelEvent;

        //Methods
        void Show();
        void Hide();
        void Close();

        void SetCountryComboBoxBindingSource(BindingSource contryList);
        void SetGenderComboBoxBindingSource(BindingSource genderList);
        void SetDepartmentComboBoxBindingSource(BindingSource departmentList);
        void enableButtons(bool value);
    }
}
