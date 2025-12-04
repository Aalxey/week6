using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Applicant(string name, int age)
        {
            Name = name;
            Age = age;
        }
        internal static class ApplicantOperations
        {
            public static void DisplayQuantifiers(List<Applicant> applicants)
            {
                bool anyUnder18 = applicants.Any(a => a.Age < 18);
                bool allAbove16 = applicants.All(a => a.Age > 16);

                Console.WriteLine("Quantifier Operators:");
                Console.WriteLine("Any applicant under 18? " + anyUnder18);
                Console.WriteLine("All applicants above 16? " + allAbove16 + "\n");
            }
        }
    }
}
