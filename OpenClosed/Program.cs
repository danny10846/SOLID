using System;
using System.Collections.Generic;

namespace OpenClosed {
    class Program {
        static void Main(string[] args) {
            var applicants = new List<IApplicantModel> {
                new PersonModel {FirstName = "Tim", LastName = "Corey"},
                new ManagerModel {FirstName = "Dan", LastName = "Allison"},
                new ExecutiveModel {FirstName = "Sue", LastName = "Storm"}

            };

            var employees = new List<EmployeeModel>();
           

            foreach (var person in applicants)
                employees.Add(person.AccountProcessor.Create(person));
            foreach (var emp in employees)
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}, Manager? : {emp.IsManager}, Exec? : {emp.IsExecutive}");

            Console.ReadLine();
        }
    }
}
