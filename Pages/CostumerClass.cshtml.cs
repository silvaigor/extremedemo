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
using System.ComponentModel.DataAnnotations;

namespace ExtremeDemo.Pages
{
    public class CostumerClassModel : PageModel
    {
        private readonly DashboardContext _context;

        public CostumerClassModel(DashboardContext context)
        {
            _context = context;
        }

         public JsonResult OnGetCostumers(DataSourceLoadOptions options)
        {
            var _data = _context.Costumers.FromSql("up_FVN_GetClientes @cTipoTercVendedor = {0}, @cCodTercVendedor = {1}", "V" ,"8077").ToList();
            return new JsonResult(DataSourceLoader.Load(_data, options));
        }
        public JsonResult OnGetClassTypes(DataSourceLoadOptions options)
        {
            return new JsonResult(DataSourceLoader.Load(SampleData.ClassTypesList, options));
        }

        public void OnPutUpdateClassTypes(string key, string values) 
        {
            Console.WriteLine(values);
        }
    }
}