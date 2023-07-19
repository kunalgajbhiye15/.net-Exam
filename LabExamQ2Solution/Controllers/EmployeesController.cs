using CookiesExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CookiesExample.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {
            List<Employee> lstDummy = new List<Employee>();
            lstDummy.Add(new Employee { Name = "Kunal", Password = "Kunal@123" });
            return View(lstDummy);
            
        }

        // GET: /Employee/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Employee/Login
        [HttpPost]
        public IActionResult Login(Employee model)
        {
            if (ModelState.IsValid)
            {
                // Logic to authenticate the employee
                if (IsValidEmployee(model.Name, model.Password))
                {
                    // Redirect to employee dashboard or any other page
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid credentials. Please try again.");
                }
            }

            return View(model);
        }

        private bool IsValidEmployee(object username, string password)
        {
            throw new NotImplementedException();
        }
        // GET: /Employee/Signup
        public IActionResult Signup()
        {
            return View();
        }

        // POST: /Employee/Signup
        [HttpPost]
        public IActionResult Signup(Employee model)
        {
            if (ModelState.IsValid)
            {
                // Logic to create a new employee account
                CreateEmployeeAccount(model);

                // Redirect to login page or any other page
                return RedirectToAction("Login");
            }

            return View(model);
        }

        private void CreateEmployeeAccount(Employee model)
        {
            throw new NotImplementedException();
        }
    }
}
