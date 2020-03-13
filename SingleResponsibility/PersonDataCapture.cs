using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility {
    public class PersonDataCapture {
        public static Person Capture() {

            Console.Write("What is your first name? ");
            var firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            var lastName = Console.ReadLine();

            return new Person { FirstName = firstName, LastName = lastName };
        }
    }
}
