﻿using Login_MVC_.Models;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Login_MVC_.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

        void connectionString()
        {
            con.ConnectionString = "data source=B-UPJAY; database=WPF; integrated security = SSPI;";
        }

        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tbl_login where username='"+acc.Name+"' and password='"+acc.Password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                return View();
            }
            
        }
    
    }
}