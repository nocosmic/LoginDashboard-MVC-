using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginDashboard_MVC_.Models;

namespace LoginDashboard_MVC_.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        EMPXEntities dbObj = new EMPXEntities();
        public ActionResult Employee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Detail model)
        {
            Detail obj = new Detail();
            obj.Name = model.Name;
            obj.COE = model.COE;
            obj.Location = model.Location;
            obj.Job = model.Job;
            obj.EmployeeNumber = model.EmployeeNumber;
            obj.BaseLocation = model.BaseLocation;
            obj.ID = model.ID;

            dbObj.Details.Add(obj);
            dbObj.SaveChanges();
            return View("Create");
        }


    }
}