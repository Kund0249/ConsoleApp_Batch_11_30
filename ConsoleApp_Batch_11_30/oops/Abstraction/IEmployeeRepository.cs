using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.oops.Abstraction
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
        void Get();
    }
}
