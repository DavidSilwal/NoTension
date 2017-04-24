﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Identity;
using WebApplication.Infrastructure.Interface.Services;
using WebApplication.Infrastructure.Services;
using WebApplication.Infrastructure.ViewModels.ProfileViewModels;

namespace WebApplication.ViewComponents
{
    [ViewComponent(Name = "Profile")]
    public class ProfileViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
