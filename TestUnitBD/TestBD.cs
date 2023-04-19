using H_Resource.Views;
using H_Resource.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using H_Resource._Repositories;
using System.Linq;

namespace TestUnitBD
{
    [TestClass]
    public class TestEmployeeRepository
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        [TestMethod]
        public async void DeberiaDevolverTodosLosEmpleados()
        {//Tiene 
            bool resultado = await employeeRepository.GetAllAsync() != null;

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void DeberiaDevolverunEmpleado()
        {//Tiene 
            int id = 100;
            bool resultado = employeeRepository.GetAsync(id) != null;

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public async void DeberiaDevolverTodosLosEmpleadosQueCoincidanConElNombre()
        {
            string nameValue = "Ste";
            IEnumerable<EmployeeModel> employeeList = await employeeRepository.FindByValueAsync("Nombre", nameValue);
            int validEmplyee = 0;
            foreach (EmployeeModel em in employeeList)
            {
                if (em.FirstName.Contains(nameValue))
                {
                    validEmplyee++;
                }
            }
            Assert.AreEqual(employeeList.Count(), validEmplyee);
        }
        [TestMethod]
        public async void DeberiaDevolverTodosLosEmpleadosQueCoincidanConElApellido()
        {
            string lastnameValue = "Par";
            IEnumerable<EmployeeModel> employeeList = await employeeRepository.FindByValueAsync("Apellido", lastnameValue);
            int validEmplyee = 0;
            foreach (EmployeeModel em in employeeList)
            {
                if (em.LastName.Contains(lastnameValue))
                {
                    validEmplyee++;
                }
            }
            Assert.AreEqual(employeeList.Count(), validEmplyee);

        }
        [TestMethod]
        public async void DeberiaDevolverTodosLosEmpleadosQueCoincidanConLaCédula()
        {
            string DocumentIdValue = "4021933";
            IEnumerable<EmployeeModel> employeeList = await employeeRepository.FindByValueAsync("Cédula", DocumentIdValue);
            int validEmplyee = 0;
            foreach (EmployeeModel em in employeeList)
            {
                if (em.DocumentId.Contains(DocumentIdValue))
                {
                    validEmplyee++;
                }
            }
            Assert.AreEqual(employeeList.Count(), validEmplyee);

        }
        [TestMethod]
        public async void DeberiaDevolverTodosLosEmpleadosQueCoincidanConElCorreo()
        {
            string emailValue = "Steven@gmail.com";
            IEnumerable<EmployeeModel> employeeList = await employeeRepository.FindByValueAsync("Correo", emailValue);
            int validEmplyee = 0;
            foreach (EmployeeModel em in employeeList)
            {
                if (em.Email.Contains(emailValue))
                {
                    validEmplyee++;
                }
            }
            Assert.AreEqual(employeeList.Count(), validEmplyee);

        }
        [TestMethod]
        public async void DeberiaDevolverTodosLosEmpleadosQueCoincidanConElTeléfono()
        {
            string PhoneValue = "8295684681";
            IEnumerable<EmployeeModel> employeeList = await employeeRepository.FindByValueAsync("Teléfono", PhoneValue);
            int validEmplyee = 0;
            foreach (EmployeeModel em in employeeList)
            {
                if (em.Phone.Contains(PhoneValue))
                {
                    validEmplyee++;
                }
            }
            Assert.AreEqual(employeeList.Count(), validEmplyee);

        }
        [TestMethod]
        public async void DeberiaDevolverTodosLosEmpleadosQueCoincidanConElDepartamento()
        {
            string DepartmentValue = "Tecnolo";
            IEnumerable<EmployeeModel> employeeList = await employeeRepository.FindByValueAsync("Departamento", DepartmentValue);
            int validEmplyee = 0;
            foreach (EmployeeModel em in employeeList)
            {
                if (em.Department.DepartmentName.Contains(DepartmentValue))
                {
                    validEmplyee++;
                }
            }
            Assert.AreEqual(employeeList.Count(), validEmplyee);

        }
        [TestMethod]
        public async void DeberiaAgregarEmpleado()
        {//Tiene 
            var employee = new EmployeeModel();
            employee.FirstName = "Raul";
            employee.LastName = "Cristobal";
            employee.DocumentId = "00198754861";
            employee.Email = "Raul@gmail.com";
            employee.DepartmentId = 1;
            employee.CountryId = 1;
            employee.Phone = "8494773124";
            employee.GenderId = 0;

            await employeeRepository.AddAsync(employee);
            EmployeeModel? AddedEmploye = new EmployeeModel();
            using (HrmsDbContext db = new HrmsDbContext())
            {
                AddedEmploye = db.Employees.SingleOrDefault(e => e.DocumentId == employee.DocumentId);
            }
            bool result = AddedEmploye != null;

            Assert.IsTrue(result);
        }
        [TestMethod]
        public async void DeberiaBorrarEmpleado()
        {//Tiene 
            var employee = new EmployeeModel();
            employee.EmployeeId = 100;
            await employeeRepository.DeleteAsync(employee);
            EmployeeModel? DeleteEmploye = new EmployeeModel();
            using (HrmsDbContext db = new HrmsDbContext())
            {
                DeleteEmploye = db.Employees.SingleOrDefault(e => e.EmployeeId == employee.EmployeeId);
            }
            bool result = DeleteEmploye != null;

            Assert.IsNull(result);
        }
        [TestMethod]
        public async void DeberiaEditarEmpleado()
        {//Tiene 
            var employee = new EmployeeModel();
            employee.EmployeeId = 103;
            employee.FirstName = "Ramon";
            employee.LastName = "Berbere";
            employee.DocumentId = "00198754861";
            employee.Email = "Raul@gmail.com";
            employee.DepartmentId = 1;
            employee.CountryId = 1;
            employee.Phone = "8494773124";
            employee.GenderId = 0;
            await employeeRepository.EditAsync(employee);
            EmployeeModel? EditEmploye = new EmployeeModel();
            using (HrmsDbContext db = new HrmsDbContext())
            {
                EditEmploye = db.Employees.SingleOrDefault(e => e.FirstName == employee.FirstName);
            }
            bool result = EditEmploye != null;

            Assert.IsTrue(result);
        }

    }
}