using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaa {

    //enums
    public enum OutputType {
        Conference, Journal, Other
    };

    public class Publication {
        public string DOI { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTime Year { get; set; }
        public OutputType Type { get; set; }
        public string CiteAs { get; set; }
        public DateTime Available { get; set; }

        //age of publication
        public int Age {
            get {
                return ...;
            }
        }
    }

}