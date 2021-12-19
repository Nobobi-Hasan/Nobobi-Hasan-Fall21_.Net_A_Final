using ApiApp.Auth;
using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    
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




        // Shop ###################################

        [Route("api/Admin/EditShop")]
        [HttpPost]
        public void EditShop(ShopModel n)
        {
            ShopService.Edit(n);
        }

        [Route("api/Admin/DeleteShop")]
        [HttpPost]
        public void DeleteShop(ShopModel n)
        {
            ShopService.Delete(n);
        }

        
        [Route("api/Admin/AllShops")]
        [HttpGet]
        public List<ShopModel> GetAllShops()
        {

            return ShopService.GetAllShops();
        }

        [Route("api/Admin/GetOneShop/{uname}")]
        [HttpGet]
        public ShopModel GetOneShop(string uname)
        {
            return ShopService.GetOneShop(uname);
        }

        [Route("api/Admin/ApproveShop/{uname}")]
        [HttpPost]
        public void ApproveShop(string uname)
        {
            ShopService.ApproveShop(uname);
        }

        [Route("api/Admin/DeclineShop/{uname}")]
        [HttpPost]
        public void DeclineShop(string uname)
        {
            ShopService.DeclineShop(uname);
        }

        [Route("api/Admin/ApprovedShops")]
        [HttpGet]
        public List<ShopModel> GetApprovedShop()
        {

            return ShopService.GetApprovedShop();
        }
        

        [Route("api/Admin/PendingShop")]
        [HttpGet]
        public List<ShopModel> GetPendingShop()
        {

            return ShopService.GetPendingShop();
        }


        //Books #############################


        [Route("api/Admin/AllBooks")]
        [HttpGet]
        public List<BookModel> GetAllBooks()
        {

            return BookService.GetAll();
        }


        //Salary #############################

        [Route("api/Admin/ApprovedSalary")]
        [HttpGet]
        public List<SalaryModel> GetApprovedSalary()
        {

            return SalaryService.GetApproved();
        }

        [Route("api/Admin/PendingSalary")]
        [HttpGet]
        public List<SalaryModel> GetPendingSalary()
        {

            return SalaryService.GetPending();
        }


        [Route("api/Admin/ApproveSalary/{id}")]
        [HttpPost]
        public void ApproveSalary(int id)
        {
            SalaryService.Approve(id);
        }

        [Route("api/Admin/DeclineSalary/{id}")]
        [HttpPost]
        public void DeclineSalary(int id)
        {
            SalaryService.Decline(id);
        }


        //Order ###########################################

        [Route("api/Admin/AllOrders")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {

            return OrderService.GetAllOrders();
        }

        [Route("api/Admin/OrderDetail/{id}")]
        [HttpGet]
        public List<OrderDetailModel> GetOrderDetail(int id)
        {

            return OrderDetailService.GetDetail(id);
        }


        //Singels ###########################################
        [Route("api/Admin/AllTransactions")]
        [HttpGet]
        public List<TransactionModel> GetAllTransactions()
        {

            return TransactionService.GetAll();
        }

        [Route("api/Admin/AllStatements")]
        [HttpGet]
        public List<StatementModel> GetAllStatements()
        {

            return StatementService.GetAll();
        }

        [Route("api/Admin/AllSupport")]
        [HttpGet]
        public List<SupportModel> GetAllSupport()
        {

            return SupportService.GetAll();
        }

        [Route("api/Admin/Profile")]
        [HttpGet]
        public AdminModel Profile()
        {
            //string uname = User.Identity.Name;
            string uname = "admin1";
            return AdminService.GetOne(uname);
        }


        [Route("api/Admin/EditProfile")]
        [HttpPost]
        public void EditProfile(AdminModel n)
        {
            AdminService.Edit(n);
        }

        [Route("api/Admin/DeleteProfile")]
        [HttpPost]
        public void DeleteProfile(AdminModel n)
        {
            AdminService.Delete(n);
        }

    }
}
