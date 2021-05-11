using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaa {

    //enums
    public enum Campus {
        Hobart, Launceston, CradleCoast
    };

    public enum EmploymentLevel {
        Student, A, B, C, D, E
    };

    public class Researcher {
        public int ID { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Title { get; set; }
        public string School { get; set; }
        public string Campus { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }

        public Position GetCurrentJob {
            get {
                return ...;
            }
        }

        public string CurrentJobTitle {
            get {
                return ...;
            }
        }

        public DateTime CurrentJobStart {
            get {
                return ...;
            }
        }

        public Position GetEarliestJob {
            get {
                return ...;
            }
        }

        public DateTime EarliestStart {
            get {
                return ...;
            }
        }

        public float Tenure {
            get {
                return ...;
            }
        }

        public int PublicationsCount {
            get {
                return ...;
            }
        }
    }

}