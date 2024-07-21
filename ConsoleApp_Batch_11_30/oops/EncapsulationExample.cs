using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_Batch_11_30.oops
{
    class Employee
    {
        private int _Code;
        private string _Name;

        public Employee()
        {
            Random random = new Random();
            _Code = random.Next(100, 999);
        }

        public int Code
        {
            get { return _Code; }
        }

        public string Name
        {
            set
            {
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                    _Name = value;
                else
                    throw new Exception("Name property is invalid!");
            }
            get { return _Name; }
        }

        public override bool Equals(object obj)
        {
            dynamic Emp;
            if (obj is Employee)
                Emp = obj;
            else
                return false;

             
            if(this.Name == Emp.Name)
            {
                return true;
            }

            return false;
        }


        //------------------Old One-------------------------
        //public int GetCode()
        //{
        //    return _Code;
        //}

        //public void SetName(string name)
        //{
        //    if (!(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)))
        //        _Name = name;
        //    else
        //        throw new Exception("Name property is invalid!");

        //}

        //public string GetName()
        //{
        //    return _Name;
        //}
    }
    internal class EncapsulationExample
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Name = "Test"
            };
            //emp.Code = -1010;
            //emp.Name = "   ";

            //emp.SetName("Test");
            //Console.WriteLine($"Code : {emp.GetCode()} Name : {emp.GetName()}");

            //emp.Name = "Test";
            Console.WriteLine($"Code : {emp.Code} Name : {emp.Name}");

            //Save emp
        }
    }
}
