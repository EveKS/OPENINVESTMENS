﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPENINVESTMENS.Components
{
    public class PartnersBlock : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
