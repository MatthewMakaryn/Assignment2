using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa
{
    public class Position
    {
        public EmploymentLevel level { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }


        public String Title()
        {
            return ToTitle(this.level);
        }

        public String ToTitle(EmploymentLevel L)
        {
            String toBeReturned = "";

            switch (L)
            {

                case EmploymentLevel.Student:
                    toBeReturned = "Student";
                    break;

                case EmploymentLevel.A:
                    toBeReturned = "Postdoc";
                    break;

                case EmploymentLevel.B:
                    toBeReturned = "Lecturer";
                    break;

                case EmploymentLevel.C:
                    toBeReturned = "Senior Lecturer";
                    break;

                case EmploymentLevel.D:
                    toBeReturned = "Associate Professor";
                    break;

                case EmploymentLevel.E:
                    toBeReturned = "Professor";
                    break;
            }
            return toBeReturned;
        }
    }

}
