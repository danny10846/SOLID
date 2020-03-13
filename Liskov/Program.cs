using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov {
    class Program {
        static void Main(string[] args) {
            IManager accountingVP = new Manager {
                FirstName = "Emma",
                LastName = "Stone"
            };
            accountingVP.CalculatePerHourRate(4);

            IEmployee emp = new Employee {
                FirstName = "Tim",
                LastName = "Corey"
            };
            
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour");
            Console.ReadLine();
        }
    }
}
