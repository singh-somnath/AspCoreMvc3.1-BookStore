using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empployee_Management.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Employee - Management MVC";
        }
    }
}
