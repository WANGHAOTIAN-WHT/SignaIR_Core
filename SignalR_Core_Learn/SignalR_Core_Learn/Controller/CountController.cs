using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SignalR_Core_Learn.Controller
{
    [Route("api/count")]
    public class CountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}