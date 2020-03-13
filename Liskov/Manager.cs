

using System;

namespace Liskov {
    public class Manager : Employee, IManager {
        

        public override void CalculatePerHourRate(int rank) {
            var baseAmount = 19.75m;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview() {
            Console.WriteLine("I'm reviewing.");
        }
    }
}
