using LoginDashboard_MVC_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;


namespace LoginDashboard_MVC_.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            // GET: Login
            [HttpGet]
            public ActionResult Login()
            {
                return View();
            }

            void connectionString()
            {
                conn.ConnectionString = "Data Source=SAK-LAPBDC599\\LOGIN;Initial Catalog=Employee;Integrated Security=True";
            }
            // Post : Login
            [HttpPost]
            public ActionResult Verify(Account acc)
            {
                connectionString();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from LOGIN where Username ='" + acc.Email + "' and Password = '" + acc.Password + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    conn.Close();
                    return View("Create");
                }
                else
                {
                    conn.Close();
                    return View("Create");
                }
            }
    }
}