using EmployeeProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        db_EmpEntities dbObj = new db_EmpEntities();
        public ActionResult Employee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(tbl_Emp model)
        {
            tbl_Emp obj = new tbl_Emp();
            obj.empid = model.empid;
            obj.empname = model.empname;
            obj.emp_email = model.emp_email;
            obj.emp_location = model.emp_location;

            dbObj.tbl_Emp.Add(obj);
            dbObj.SaveChanges();

            return View("Employee");
        }

    }
}