
using System;

namespace SingleResonponsibility {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to my application!");

            //Ask for user info 
            Person user = new Person();

            Console.Write("What is your first name? ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            user.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.FirstName)) {
                Console.WriteLine("You did not give a valid first name!");
                Console.ReadLine();
                return;
            }
            if (string.IsNullOrWhiteSpace(user.LastName)) {
                Console.WriteLine("You did not give a valid last name!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}.{user.LastName}");
            Console.ReadLine();
        }
    }
}
