using CustomerManagementApp.Core.Data;
using CustomerManagementApp.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApp.Core.Interfaces
{
    public interface ICustomerReport
    {
        double GetAverageAge(List<Customer> customers);
        double GetAverageAge(List<Customer> customers, Gender gender);
        //Combine both as a string output:
        string GenerateSummaryReport(List<Customer> customers);
    }
}