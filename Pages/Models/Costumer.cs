using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtremeDemo.Pages.Models
{
    public class Costumer
    {
        public string cTipoTerceiro { get; set; }
        
        [Key]
        public string cCodTerceiro { get; set; }
        
        public string vcNome { get; set; }
        public string vcMorada { get; set; }
        public decimal mSaldo { get; set; }
        public string cClassificacaoFact { get; set; }
    }
}