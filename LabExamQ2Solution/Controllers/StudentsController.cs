using CookiesExample.Models;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CookiesExample.Controllers
{
    public class StudentsController : Controller
    {
        // GET: StudentsController
        public ActionResult Index()
        {
            List<Student> lstDummy = new List<Student>();
            lstDummy.Add(new Student { Name = "Kunal", Password = "Kunal@123" });
            return View(lstDummy);
        }

        // GET: /Employee/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Employee/Login
        [HttpPost]
        public IActionResult Login(Student model)
        {
            if (ModelState.IsValid)
            {
                // Logic to authenticate the employee
                if (IsValidStudent(model.Name, model.Password))
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

        private bool IsValidStudent(string name, string password)
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
        public IActionResult Signup(Student model)
        {
            if (ModelState.IsValid)
            {
                // Logic to create a new employee account
                CreateStudentAccount(model);

                // Redirect to login page or any other page
                return RedirectToAction("Login");
            }

            return View(model);
        }

        private void CreateStudentAccount(Student model)
        {
            throw new NotImplementedException();
        }

        // Additional actions, such as Dashboard, Edit, Delete, etc., can be added here
    }
    



  }

