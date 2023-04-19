using H_Resource._Repositories;
using H_Resource.Models;
using H_Resource.Views;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Presenters
{
    public class EmployeeDetailPresenter
    {
        //Fields
        private readonly IEmployeeDetailView view;
        private IEmployeeRepository repository;
        private BindingSource CountryBindingSource;
        private BindingSource GenderBindSource;
        private BindingSource DepartemntBindingSource;
        private bool isCached = true;

        //Constructor
        public EmployeeDetailPresenter(IEmployeeDetailView view, IEmployeeRepository repository)
        {
            CountryBindingSource = new BindingSource();
            GenderBindSource = new BindingSource();
            DepartemntBindingSource = new BindingSource();
            

            this.view = view;
            this.repository = repository;

            //Methods

            this.view.ShowEmployeesView += ShowEmployeesView;
            this.view.CancelEvent += ShowEmployeesView;
            this.view.SaveEvent += SaveEvent;
            PreloadBindingData();
            this.view.SetCountryComboBoxBindingSource(CountryBindingSource);
            this.view.SetDepartmentComboBoxBindingSource(DepartemntBindingSource);
            this.view.SetGenderComboBoxBindingSource(GenderBindSource);
            this.view.Show();
        }

        private void ShowEmployeesView(object? sender, EventArgs e)
        {
            MainContainer container = MainContainer.GetInstance();
            EmployeeView view = EmployeeView.GetInstance(container);
            cleanViewFields();
            view.IsCached = this.isCached;
            container.AddView(view);
            _ = new EmployeePresenter(view, new EmployeeRepository());
            this.view.Hide();
        }

        private void PreloadBindingData()
        {
            List<CountryModel> countryList = new List<CountryModel>();
            List<GenderModel> genders = new List<GenderModel>();
            List<DepartmentModel> depts = new List<DepartmentModel>();
            using (HrmsDbContext db = new HrmsDbContext())
            {
                countryList = db.Countries.ToList();
                genders = db.Genders.ToList();
                depts = db.Departments.ToList();
            }
            CountryBindingSource.DataSource = countryList;
            GenderBindSource.DataSource = genders;
            DepartemntBindingSource.DataSource = depts;

        }

        private async void SaveEvent(object? sender, EventArgs e)
        {
            try
            {
                var model = new EmployeeModel();
                model.FirstName = view.FirstName;
                model.LastName = view.LastName;
                model.Email = view.Email;
                model.Phone = view.Phone;
                model.BirthDate = view.BirthDate;
                model.Address = view.Address;
                model.HireDate = view.HireDate;
                model.CountryId = Convert.ToInt32(view.CountryId);
                model.DepartmentId = Convert.ToInt32(view.DepartmentId);
                model.DocumentId = view.DocuemntId;
                model.GenderId = Convert.ToInt32(view.GenderId);

                if (view.Image != null)
                {
                    using (var bitmap = new Bitmap(view.Image))
                    {
                        using (var ms = new MemoryStream())
                        {
                            bitmap.Save(ms, ImageFormat.Bmp);
                            model.Image = ms.ToArray();
                        }
                    }
                }

                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    model.EmployeeId = Convert.ToInt32(view.EmployeeId);
                    await repository.EditAsync(model);
                    MessageBox.Show("El empleado fue actualizado exitosamente!");
                }
                else // Add new Model
                {
                    await repository.AddAsync(model);
                    MessageBox.Show("El empleado fue añadido exitosamente!");
                }
                this.isCached = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cleanViewFields()
        {
            view.EmployeeId = "";
            view.FirstName = "";
            view.LastName = "";
            view.Email = "";
            view.Phone = "";
            view.Address = "";
            view.GenderId = 0;
            view.DepartmentId = 0;
            view.DocuemntId = "";
            view.CountryId = 0;
            view.BirthDate = DateTime.Now;
            view.HireDate = DateTime.Now;
            view.Image = null;
            view.Phone = "";
        }
    }
}
