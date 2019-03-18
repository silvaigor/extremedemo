using System.Collections.Generic;

namespace ExtremeDemo.Pages.Models
{
    public partial class SampleData {
        public static List<ClassTypes> ClassTypesList {
            get {
                return new List<ClassTypes> {
                    new ClassTypes {
                        vcClassType = "A",
                        vcCor ="#FF5733"
                    },
                    new ClassTypes {
                       vcClassType = "B",
                       vcCor = "#27AE60"
                    },
                    new ClassTypes {
                        vcClassType = "C",
                        vcCor = "#2E86C1"
                    }              
                };
            }
        }
    }
}
