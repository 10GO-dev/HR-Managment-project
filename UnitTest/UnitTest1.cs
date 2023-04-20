using H_Resource.Views;
using H_Resource.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using H_Resource._Repositories;
using System.Linq;
namespace UnitTest
{
    public class Tests
    {
        //Para correr este test debe tener conexión al servidor.
         EmployeeRepository employeeRepository;
        [SetUp]
        public void Setup()
        {
            employeeRepository = new EmployeeRepository();
        }

        [Test]
        public async Task t1DeberiaDevolverTodosLosEmpleados()
        {//Tiene 
            bool resultado = await employeeRepository.GetAllAsync() != null;

            Assert.IsTrue(resultado);
        }
        [Test]
        public void t2DeberiaDevolverunEmpleado()
        {//Tiene 
            int id = 100;
            bool resultado = employeeRepository.GetAsync(id) != null;

            Assert.IsTrue(resultado);
        }
        [Test]
        public async Task t3DeberiaDevolverTodosLosEmpleadosQueCoincidanConElNombre()
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
        [Test]
        public async Task t4DeberiaDevolverTodosLosEmpleadosQueCoincidanConElApellido()
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
        [Test]
        public async Task t5DeberiaDevolverTodosLosEmpleadosQueCoincidanConLaCédula()
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
        [Test]
        public async Task t6DeberiaDevolverTodosLosEmpleadosQueCoincidanConElCorreo()
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
        [Test]
        public async Task t7DeberiaDevolverTodosLosEmpleadosQueCoincidanConElTeléfono()
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
        [Test]
        public async Task t8DeberiaDevolverTodosLosEmpleadosQueCoincidanConElDepartamento()
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
        [Test]
        public async Task t91DeberiaAgregarEmpleado()
        {//Tiene 
            var employee = new EmployeeModel();
            employee.FirstName = "Raul";
            employee.LastName = "Cristobal";
            employee.DocumentId = "00198754861";
            employee.Email = "Raul@gmail.com";
            employee.DepartmentId = 1;
            employee.CountryId = 1;
            employee.Phone = "8494773124";
            employee.GenderId = 1;

            await employeeRepository.AddAsync(employee);
            EmployeeModel? AddedEmploye = new EmployeeModel();
            using (HrmsDbContext db = new HrmsDbContext())
            {
                AddedEmploye = db.Employees.AsNoTracking().SingleOrDefault(e => e.DocumentId == employee.DocumentId);
            }
            bool result = AddedEmploye != null;

            Assert.IsTrue(result);
        }
        [Test]
        public async Task t92DeberiaEditarEmpleado()
        {//Tiene 
            var employee = new EmployeeModel();
            EmployeeModel? EditedEmployee = new EmployeeModel();
            using (HrmsDbContext db = new HrmsDbContext())
            {
                employee = db.Employees.AsNoTracking().SingleOrDefault(e => e.DocumentId == "00198754861");
                employee.FirstName = "Ramon";
                await employeeRepository.EditAsync(employee);
                EditedEmployee = db.Employees.AsNoTracking().SingleOrDefault(e => e.FirstName == employee.FirstName);

            }
            bool result = EditedEmployee != null;

            Assert.IsTrue(result);
        }
        [Test]
        public async Task t93DeberiaBorrarEmpleado()
        {//Tiene 
            var employee = new EmployeeModel();
            EmployeeModel? DeletedEmploye = new EmployeeModel();
            using (HrmsDbContext db = new HrmsDbContext())
            {
                employee = db.Employees.AsNoTracking().SingleOrDefault(e => e.DocumentId == "00198754861");
                await employeeRepository.DeleteAsync(employee);
                DeletedEmploye = db.Employees.AsNoTracking().SingleOrDefault(e => e.DocumentId == employee.DocumentId);

            }

            Assert.IsNull(DeletedEmploye);
        }
        
    }
}

