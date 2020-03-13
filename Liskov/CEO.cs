using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov {
    public class CEO : BaseEmployee, IManager {
        public override void CalculatePerHourRate(int rank) {
            var baseAmount = 150m;
            Salary = baseAmount * rank;
        }

       

        public void GeneratePerformanceReview() {
            Console.WriteLine("I'm reviewing a direct report's performance");
        }
        public void FireSomeone() {
            Console.WriteLine("You're fired!");
        }
    }
}
