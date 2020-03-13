using System;

namespace SingleResponsibility {
    public class StandardMessages {
        public static void WelcomeMessage() {
            Console.WriteLine("Welcome to my application!");
        }

        public static void ExitProgram() {
            Console.ReadLine();
        }

        public static void ValidationError(string fieldName) {
            Console.WriteLine($"You did not provide the correct {fieldName} name!");
        }
    }
}
