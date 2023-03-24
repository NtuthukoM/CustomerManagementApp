
using CustomerManagementApp.Core.Data;
using CustomerManagementApp.Core.Implementation;
using CustomerManagementApp.Core.Interfaces;

var customers = CustomerData.GetCustomers();

ICustomerReport customerReport = new CustomerReport();

string reportData = customerReport.GenerateSummaryReport(customers);
Console.WriteLine(reportData);
Console.Read();
