﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static KetabKhanaFEntities db;
        static DataAccessFactory()
        {
            db = new KetabKhanaFEntities();
        }

        public static IRepo<Admin, string, string> AdminDataAcess()
        {
            return new AdminRepo(db);
        }

        public static IRepo<Employee, string, string> EmployeeDataAcess()
        {
            return new EmployeeRepo(db);
        }

        public static IShop<Shop, string> ShopDataAcess()
        {
            return new ShopRepo(db);
        }

        public static IRepo<Customer, string, string> CustomerDataAcess()
        {
            return new CustomerRepo(db);
        }


        public static IRepo<Book, int, string> BookDataAcess()
        {
            return new BookRepo(db);
        }

        public static ICart<Cart, int, string> CartDataAcess()
        {
            return new CartRepo(db);
        }


        public static IRepo<OrderDetail, string> OrderDetailDataAcess()
        {
            return new OrderDetailRepo(db);
        }


        public static IOrder<Order, int, string> OrderDataAcess()
        {
            return new OrderRepo(db);
        }

        public static ISalary<Salary, int> SalaryDataAcess()
        {
            return new SalaryRepo(db);
        }

        public static IRepo<Statement> StatementDataAcess()
        {
            return new StatementRepo(db);
        }

        public static IRepo<Support> SupportDataAcess()
        {
            return new SupportRepo(db);
        }


        public static IRepo<Transaction, string> TransactionDataAcess()
        {
            return new TransactionRepo(db);
        }





    }
}