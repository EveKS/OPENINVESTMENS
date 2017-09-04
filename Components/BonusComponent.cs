using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPENINVESTMENS.Components
{
    public class Bonus : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
