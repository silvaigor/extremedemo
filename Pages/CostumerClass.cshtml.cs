using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ExtremeDemo.Pages.Models;

namespace ExtremeDemo.Pages
{
    public class CostumerClassModel : PageModel
    {
         public JsonResult OnGetCostumers(DataSourceLoadOptions options)
    {
            return new JsonResult(DataSourceLoader.Load(SampleData.Appointments, options));
    }
        public void OnGet()
        {
        }
    }
}