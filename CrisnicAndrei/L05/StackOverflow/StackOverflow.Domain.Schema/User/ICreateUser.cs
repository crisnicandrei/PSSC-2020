using System;
using System.Collections.Generic;

namespace StackOverflow.Domain.Schema.User
{
    public class ICreateUser
    {
        public static ICreateUser CreateUser(UserMO receivedRegistration) {
            if (string.IsNullOrWhiteSpace(receivedRegistration.firstName) ||
                string.IsNullOrWhiteSpace(receivedRegistration.lastName)  ||
                string.IsNullOrWhiteSpace(receivedRegistration.email))    {
                    IEnumerable<string> errors = new List<string>() {
                      "First name cannot be empty",
                      "Last name cannot be empty",
                      "Email address is invalid"  
                    };
                    return new UserNotValidated(errors);
            }

            return new UserCreated(receivedRegistration, Guid.NewGuid());
    }
}
}