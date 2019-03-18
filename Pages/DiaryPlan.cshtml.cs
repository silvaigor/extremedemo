using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using ExtremeDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ExtremeDemo.Pages
{
    public class DiaryPlanModel : PageModel
    {
        private readonly DashboardContext _context;

        public DiaryPlanModel(DashboardContext context)
        {
            _context = context;
        }
        
        public JsonResult OnGetCustomerFails(DataSourceLoadOptions options)
        {
              var _data = _context.Costumers.FromSql("up_FVN_PlanoDiarioFalhas @cTipoTercVendedor = {0}, @cCodTercVendedor = {1}", "V" ,"8077").ToList();
            return new JsonResult(DataSourceLoader.Load(_data, options));
            
        }


    }
}