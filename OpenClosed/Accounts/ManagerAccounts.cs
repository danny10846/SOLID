using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed {
    class ManagerAccounts : IAccounts {
        public EmployeeModel Create(IApplicantModel person) {
            //Refactor with new class 
            return new EmployeeModel {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@hotmail.corp",
                IsManager = true
                
            };
        }
    }
}
