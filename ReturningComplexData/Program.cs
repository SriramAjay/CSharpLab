using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningComplexData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread Started");
            Task<Employee> task = Task<Employee>.Factory.StartNew(() => {
                Employee emp = new Employee() { ID=1,Name="Ajay",Salary=1000 };
                return emp;
            });
            Console.WriteLine($"ID:{task.Result.ID},Name:{task.Result.Name},Salary:{task.Result.Salary}");
            Console.WriteLine($"Main Thread Completed");
            Console.ReadKey();
        }
    }
    public class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
