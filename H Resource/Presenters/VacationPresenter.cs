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
            this._vacationView.EditEvent += EditVacation;
            this._vacationView.SearchEvent += SearchEvent;
            this._vacationView.ShowHomeView += ShowHomeView;
            this._vacationView.SaveEvent += SaveChanges;
            this._vacationView.SetVacationListBindingSource(VacationBindingSource);
            this._vacationView.SetEmployeeDetailBindingSource(EmployeesBindingSource);
            this._vacationView.SelectEmployeeClick += SelectEmployeeToEdit;
            LoadAllVactions();
            _vacationView.Show();
        }

        private async void SaveChanges(object? sender, EventArgs e)
        {
            try
            {

                VacationModel vacation = new VacationModel();
                vacation.VacationId = Convert.ToInt32(_vacationView.VacationID);
                vacation.StartDate = _vacationView.StartDate;
                vacation.EndDate = _vacationView.EndDate;
                vacation.EmployeeId = _vacationView.EmployeeID;
                vacation.TakenDays = Convert.ToInt32(_vacationView.TakenDays);
                if (_vacationView.IsEdit) // Edit Vacation
                {
                    await vacationRepository.EditAsync(vacation);
                    MessageBox.Show("Vacación actualizada correctamente");
                }
                else //Add new Vacation
                {
                    await vacationRepository.AddAsync(vacation);
                    MessageBox.Show("Vacación añadida correctamente");
                }
                _vacationView.GoBack();
                vacationList = null;
                _vacationView.IsEdit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _vacationView.IsCached = false;
            }
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
            this._vacationView.AddEvent -= AddVacation;
            this._vacationView.EditEvent -= EditVacation;
            this._vacationView.SearchEvent -= SearchEvent;
            this._vacationView.ShowHomeView -= ShowHomeView;
            this._vacationView.SaveEvent -= SaveChanges;
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
            var selectedVacation =(VacationEmployeeList?)VacationBindingSource.Current;
            if (selectedVacation != null)
            {
                EmployeeModel vacationEmployee = employeeRepository.GetAsync(selectedVacation.EmployeeId);

                if (vacationEmployee != null)
                {
                    _vacationView.IsEdit = true;
                    _vacationView.VacationID = selectedVacation.VacationID;
                    _vacationView.EmployeeID = selectedVacation.EmployeeId;
                    _vacationView.FullName = vacationEmployee.FirstName + " " + vacationEmployee.LastName;
                    _vacationView.Department = vacationEmployee.Department.DepartmentName;
                    _vacationView.DocumentId = vacationEmployee.DocumentId;
                    if (vacationEmployee.Image != null)
                    {
                        byte[] imageBytes = vacationEmployee.Image;
                        using (MemoryStream ms = new(imageBytes))
                        {
                            _vacationView.Image = Image.FromStream(ms);
                        };
                    }
                    else _vacationView.Image = Properties.Resources.Img_Avatar;
                    _vacationView.HireDate = vacationEmployee.HireDate;
                    _vacationView.AvailableDays = vacationEmployee.AvailableDays.ToString();
                    _vacationView.StartDate = selectedVacation.StartDate;
                    _vacationView.EndDate = selectedVacation.EndDate;
                }
            }
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
