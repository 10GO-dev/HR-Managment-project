using H_Resource._Repositories;
using H_Resource.Models;
using H_Resource.Models.Request;
using H_Resource.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Presenters
{
    public class VacationPresenter
    {
        private readonly IVacationView _vacationView;
        private IVacationRepository vacationRepository;
        private IEmployeeRepository employeeRepository;
        private BindingSource VacationBindingSource;
        private BindingSource EmployeesBindingSource;
        private IEnumerable<VacationEmployeeList?> vacationList;
        private IEnumerable<EmployeeModel?> employeesDetail;
        private static List<VacationEmployeeList>? _cachedVacations;
        

        public VacationPresenter(IVacationView vacationView, IVacationRepository vacationRepository, IEmployeeRepository employeeRepository)
        {
            VacationBindingSource = new BindingSource();
            EmployeesBindingSource = new BindingSource();
            _vacationView = vacationView;
            this.vacationRepository = vacationRepository;
            this.employeeRepository = employeeRepository;
            this._vacationView.AddEvent += AddVacation;
            this._vacationView.RemoveEvent += RemoveVacation;
            this._vacationView.EditEvent += EditVacation;
            this._vacationView.SearchEvent += SearchEvent;
            this._vacationView.ShowHomeView += ShowHomeView;
            this._vacationView.SetVacationListBindingSource(VacationBindingSource);
            this._vacationView.SetEmployeeDetailBindingSource(EmployeesBindingSource);
            this._vacationView.SelectEmployeeClick += SelectEmployeeToEdit;
            LoadAllVactions();
            _vacationView.Show();
        }

        private async void SelectEmployeeToEdit(object? sender, EventArgs e)
        {
            List<EmployeeVacationViewModel>? employeeList = EmployeesBindingSource.DataSource as List<EmployeeVacationViewModel>;

            EmployeeVacationViewModel selectedEmployee = employeeList[_vacationView.SelectedEmployeeIndex];

            if (selectedEmployee != null && selectedEmployee.EmployeeId != _vacationView.EmployeeID)
            {
                EmployeeModel model = employeesDetail.FirstOrDefault(e => e.EmployeeId == selectedEmployee.EmployeeId)??employeeRepository.GetAsync(selectedEmployee.EmployeeId);
                _vacationView.EmployeeID = selectedEmployee.EmployeeId;
                _vacationView.FullName = model.FirstName + " " + model.LastName;
                _vacationView.Department = model.Department.DepartmentName;
                _vacationView.DocumentId = model.DocumentId;
                if (model.Image != null)
                {
                    byte[] imageBytes = model.Image;
                    using (MemoryStream ms = new(imageBytes))
                    {
                        _vacationView.Image = Image.FromStream(ms);
                    };
                }else _vacationView.Image = Properties.Resources.Img_Avatar;
                _vacationView.HireDate = model.HireDate;
                _vacationView.AvailableDays = model.AvailableDays.ToString();
            }
        }

        private void ShowHomeView(object? sender, EventArgs e)
        {
            MainContainer mainContainer = MainContainer.GetInstance();
            IHomeView view = HomeView.GetInstance(mainContainer);
            mainContainer.AddView((Form)view);
            new HomePresenter(view);
            this._vacationView.Close();
        }

        private async void SearchEvent(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(_vacationView.SearchValue);
            if (_cachedVacations != null)
            {
                vacationList = !emptyValue ? _cachedVacations.Where(e => e.FullName.Contains(_vacationView.SearchValue)) : (IEnumerable<VacationEmployeeList?>)_cachedVacations;
            }
            else
            {
                vacationList = !emptyValue ? await vacationRepository.FindByValueAsync(this._vacationView.SearchValue) : await vacationRepository.GetAllAsync();
            }
            VacationBindingSource.DataSource = vacationList;
        }

        private void EditVacation(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RemoveVacation(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void AddVacation(object? sender, EventArgs e)
        {
            if(employeesDetail == null)
            {
                employeesDetail = await employeeRepository.GetAllAsync();
            }
            List<EmployeeVacationViewModel> employeeSelect = employeesDetail.Select(e => new EmployeeVacationViewModel
            {
                EmployeeId = e.EmployeeId,
                FullName = e.FirstName + " " + e.LastName,
                AvailableDays = e.AvailableDays
            }).ToList();
            EmployeesBindingSource.DataSource = employeeSelect;
        }

        private async void LoadAllVactions()
        {
            if(_cachedVacations != null && _vacationView.IsCached) {
                VacationBindingSource.DataSource = _cachedVacations;
                return;
            }
            vacationList = await vacationRepository.GetAllAsync();
            VacationBindingSource.DataSource = vacationList;
            
        }
    }
}
