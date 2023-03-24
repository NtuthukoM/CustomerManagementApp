using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApp.Core.Data
{
    public class CustomerData
    {
        public static List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{ Name = "Andy", DateOfBirth = DateTime.Now.AddYears(-19), Gender = Gender.Male },
                new Customer{ Name = "Alice", DateOfBirth = DateTime.Now.AddYears(-12), Gender = Gender.Female },
                new Customer{ Name = "Alex", DateOfBirth = DateTime.Now.AddYears(-20), Gender = Gender.Male },
                new Customer{ Name = "Andiswa", DateOfBirth = DateTime.Now.AddYears(-52), Gender = Gender.Female },
                new Customer{ Name = "Zenzele", DateOfBirth = DateTime.Now.AddYears(-46), Gender = Gender.Male },
            };
        }
    }
}
