﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Areas.Feed.Controllers
{
    [Area("Feed")]
    [Authorize()]
    public class MyFeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
