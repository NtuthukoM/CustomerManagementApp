using CustomerManagementApp.Core.Data;
using CustomerManagementApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApp.Core.Implementation
{
    public class CustomerReport : ICustomerReport
    {
        public string GenerateSummaryReport(List<Customer> customers)
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine("\t\t- Customer Report -");
            report.AppendLine("\t\t-------------------");
            double avgAge = GetAverageAge(customers);
            report.AppendLine($"\t- Average customer age:       \t {avgAge}");
            //Age by gender:
            avgAge = GetAverageAge(customers, Gender.Male);
            report.AppendLine($"\t- Average male customer age:  \t {avgAge}");
            avgAge = GetAverageAge(customers, Gender.Female);
            report.AppendLine($"\t- Average female customer age:\t {avgAge}");
            report.AppendLine("");
            report.AppendLine("\t\t-------------------");
            return report.ToString();
        }

        public double GetAverageAge(List<Customer> customers)
        {
            var avg = customers.Average(x => x.Age);
            return Math.Round(avg, 2);
        }

        public double GetAverageAge(List<Customer> customers, Gender gender)
        {
            var avg = customers.Where(x => x.Gender == gender)
                .Average(x => x.Age);
            return Math.Round(avg, 2);
        }

    }
}
