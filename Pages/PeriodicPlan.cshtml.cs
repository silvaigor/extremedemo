using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ExtremeDemo.Pages.Models;
using ExtremeDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace ExtremeDemo.Pages
{
    public class PeriodicPlanModel : PageModel
    {
         private readonly DashboardContext _context;

        public PeriodicPlanModel(DashboardContext context)
        {
            _context = context;
        }
        
        public JsonResult OnGetSelectPlan(DataSourceLoadOptions options)
        {
            var _data = _context.PeriodicPlanList.FromSql("up_FVN_PlaneamentoPeriodico_NOVO @iProcesso = {0}, @iPeriodoID = {1}, @dtDataAnalise = {2}", "26574" ,"1", "2019-03-11 00:00:00.000").ToList();
            return new JsonResult(DataSourceLoader.Load(_data, options));
        }
        
        public void OnGet()
        {
            Console.WriteLine("ele veio aqui");
        }
    }
}