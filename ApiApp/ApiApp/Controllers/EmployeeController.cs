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
    public class EmployeeController : ApiController
    {

        //Order ###########################################

        [Route("api/Employee/AllOrders")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {

            return OrderService.GetAllOrders();
        }

        [Route("api/Employee/OrderDetail/{id}")]
        [HttpGet]
        public List<OrderDetailModel> GetOrderDetail(int id)
        {

            return OrderDetailService.GetDetail(id);
        }


        [Route("api/Employee/GetAllCancelRequestOrders")]
        [HttpGet]
        public List<OrderModel> GetAllCancelRequestOrders()
        {

            return OrderService.GetAllCancelRequestOrders();
        }


        [Route("api/Employee/CancelRequest/Approve/{id}")]
        [HttpPost]
        public void ApproveCancel(int id)
        {
            OrderService.ApproveCancel(id);
        }


        [Route("api/Employee/CancelRequest/Decline/{id}")]
        [HttpPost]
        public void DeclineCancel(int id)
        {
            OrderService.DeclineCancel(id);
        }



        [Route("api/Employee/AllCanceledOrders")]
        [HttpGet]
        public List<OrderModel> GetAllCanceledOrders()
        {

            return OrderService.GetAllCanceledOrders();
        }


        //Salary ###########################################

        [Route("api/Employee/ApprovedSalary")]
        [HttpGet]
        public List<SalaryModel> GetApprovedSalaries()
        {

            return SalaryService.GetApproved();
        }


        [Route("api/Employee/AddSalary")]
        [HttpPost]
        public void AddSalary(SalaryModel s)
        {
            SalaryService.Add(s);
        }


        //Statement ###########################################

        [Route("api/Employee/AllStatements")]
        [HttpGet]
        public List<StatementModel> GetAllStatements()
        {

            return StatementService.GetAll();
        }


        [Route("api/Employee/AddStatement")]
        [HttpPost]
        public void AddStatement(StatementModel s)
        {
            StatementService.Add(s);
        }


        //Transaction ###########################################

        [Route("api/Employee/AllTransactions")]
        [HttpGet]
        public List<TransactionModel> GetAllTransactions()
        {

            return TransactionService.GetAll();
        }


        [Route("api/Employee/AddTransaction")]
        [HttpPost]
        public void AddTransaction(TransactionModel s)
        {
            TransactionService.Add(s);
        }



        //Support ###########################################

        [Route("api/Employee/AddSupport")]
        [HttpPost]
        public void AddSupport(SupportModel s)
        {
            SupportService.Add(s);
        }

        //Profile ###########################################

        [Route("api/Employee/Profile")]
        [HttpGet]
        public EmployeeModel Profile()
        {
            //string uname = User.Identity.Name;
            string uname = "emp1";
            return EmployeeService.GetOne(uname);
        }


        [Route("api/Employee/EditProfile")]
        [HttpPost]
        public void EditProfile(EmployeeModel n)
        {
            EmployeeService.Edit(n);
        }

        [Route("api/Employee/DeleteProfile")]
        [HttpPost]
        public void DeleteProfile(EmployeeModel n)
        {
            EmployeeService.Delete(n);
        }

    }
}
