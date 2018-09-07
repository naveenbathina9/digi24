using Digi24.BusinessLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Digi24.Web.Controllers
{
    public class EmployeeHomeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeHomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: EmployeeHome
        public ActionResult Index()
        {
            return View();
        }

    }
}