﻿using System;

namespace DI {
    internal class Emailer : IMessageSender {
        public void SendMessage(IPerson person, string message) {
            Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
        }
    }
}