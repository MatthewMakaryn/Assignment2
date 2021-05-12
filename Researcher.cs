using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace aaaa {

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

        public List<Position> Positions;

        public List<Publication> Publications;

        public Position GetCurrentJob {
            get {
                var toBeReturned = from job in Positions
                                   where job.end == null
                                   select job;

                return (Position)toBeReturned;
            }
        }

        public string CurrentJobTitle {
            get {
                return this.GetCurrentJob.Title();
            }
        }

        public DateTime CurrentJobStart {
            get {
                return this.GetCurrentJob.start;
            }
        }

        public Position GetEarliestJob {
            get {
                Position currentEarliest = this.Positions[0];

                var toBeReturned = from job in Positions
                                   where (DateTime.Compare(job.start, currentEarliest.start) < 1)
                                   select job;

                return (Position)toBeReturned;
            }
        }

        public DateTime EarliestStart {
            get {
                return this.GetEarliestJob.start;
            }
        }

        public float Tenure {
            get {
                return  ( (float)DateTime.Now.Subtract(this.EarliestStart).Days ) / (float)365.0;
            }
        }

        public int PublicationsCount {
            get {
                return this.Publications.Count;
            }
        }
    }

    public class Student : Researcher {
        public string Degree { get; set; }
    }
}