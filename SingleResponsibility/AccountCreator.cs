﻿using System;

namespace SingleResponsibility {
    public class AccountCreator {
        
        public static void CreateAccount(Person user) {
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}.{user.LastName}");
        }
    }
}
