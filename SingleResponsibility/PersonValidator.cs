
using System;

namespace SingleResponsibility {
    public class PersonValidator {
        public static bool ValidateUser(Person user) {
            if (string.IsNullOrWhiteSpace(user.FirstName)) {
                StandardMessages.ValidationError("first");
                StandardMessages.ExitProgram();
                return false;
            }
            if (string.IsNullOrWhiteSpace(user.LastName)) {
                StandardMessages.ValidationError("last");
                StandardMessages.ExitProgram();
                return false;
            } 
            return true;
        }
    }
}
