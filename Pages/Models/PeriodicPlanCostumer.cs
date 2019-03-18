using System;
using System.ComponentModel.DataAnnotations;

namespace ExtremeDemo.Pages.Models
{
    public class PeriodicPlanCostumer
    {
        [Key]
        public string Chave { get; set; }
        public string vcNome { get; set; }
        public DateTime dtDataIni { get; set; }
        public DateTime dtDataFim { get; set; }
        public string vcCodClass { get; set; }
    }
}