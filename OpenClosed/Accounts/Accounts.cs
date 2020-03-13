using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed {
    public class Accounts : IAccounts {

        public EmployeeModel Create(IApplicantModel person) {
            return new EmployeeModel {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@hotmail.com"
            };
        }
    }
}
