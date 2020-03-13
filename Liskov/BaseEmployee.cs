using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov {
    public abstract class BaseEmployee : IEmployee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
       
        

        public virtual void CalculatePerHourRate(int rank) {
            var baseAmount = 12.50m;
            Salary = baseAmount + (rank * 2);
        }
    }
}
