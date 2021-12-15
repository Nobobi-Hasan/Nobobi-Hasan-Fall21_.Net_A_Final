using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiApp.Controllers
{
    public class AdminController : ApiController
    {

        // Admin ###################################

        [Route("api/Admin/CreateAdmin")]
        [HttpPost]
        public void AddAdmin(AdminModel n)
        {
            //string sId = User.Identity.Name;
            //int id = Int32.Parse(sId);
            //n.SupervisorId = id;
            AdminService.Add(n);
        }

        [Route("api/Admin/EditAdmin")]
        [HttpPost]
        public void EditAdmin(AdminModel n)
        {
            AdminService.Edit(n);
        }

        [Route("api/Admin/DeleteAdmin")]
        [HttpPost]
        public void DeleteAdmin(AdminModel n)
        {
            AdminService.Delete(n);
        }

        [Route("api/Admin/AllAdmins")]
        [HttpGet]
        public List<AdminModel> GetAllAdmins()
        {

            return AdminService.GetAll();
        }

        [Route("api/Admin/GetOneAdmin/{uname}")]
        [HttpGet]
        public AdminModel GetOneAdmin(string uname)
        {
            return AdminService.GetOne(uname);
        }


        // Employee ###################################

        [Route("api/Admin/CreateEmployee")]
        [HttpPost]
        public void AddEmployee(EmployeeModel n)
        {
            EmployeeService.Add(n);
        }

        [Route("api/Admin/EditEmployee")]
        [HttpPost]
        public void EditEmployee(EmployeeModel n)
        {
            EmployeeService.Edit(n);
        }

        [Route("api/Admin/DeleteEmployee")]
        [HttpPost]
        public void DeleteEmployee(EmployeeModel n)
        {
            EmployeeService.Delete(n);
        }

        [Route("api/Admin/AllEmployees")]
        [HttpGet]
        public List<EmployeeModel> GetAllEmployees()
        {

            return EmployeeService.GetAll();
        }

        [Route("api/Admin/GetOneEmployee/{uname}")]
        [HttpGet]
        public EmployeeModel GetOneEmployee(string uname)
        {
            return EmployeeService.GetOne(uname);
        }


        // Customer ###################################


        [Route("api/Admin/EditCustomer")]
        [HttpPost]
        public void EditCustomer(CustomerModel n)
        {
            CustomerService.Edit(n);
        }

        [Route("api/Admin/DeleteCustomer")]
        [HttpPost]
        public void DeleteCustomer(CustomerModel n)
        {
            CustomerService.Delete(n);
        }

        [Route("api/Admin/AllCustomers")]
        [HttpGet]
        public List<CustomerModel> GetAllCustomers()
        {

            return CustomerService.GetAll();
        }

        [Route("api/Admin/GetOneCustomer/{uname}")]
        [HttpGet]
        public CustomerModel GetOneCustomer(string uname)
        {
            return CustomerService.GetOne(uname);
        }



    }
}
