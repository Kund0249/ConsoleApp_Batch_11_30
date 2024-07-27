using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.oops.Abstraction
{
    internal class AzEmployeeRepository : IEmployeeRepository
    {
        public void Add(Employee employee)
        {
            Console.WriteLine("Data inserted successfully! : AZ");
        }

        public void Delete(Employee employee)
        {
            Console.WriteLine("Data delete successfully! : AZ");
        }

        public void Get()
        {
            Console.WriteLine("Data fetched successfully! : AZ");
        }

        public void Update(Employee employee)
        {
            Console.WriteLine("Data updated successfully! : AZ");
        }
    }
}
