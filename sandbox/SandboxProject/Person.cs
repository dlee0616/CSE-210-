using System;

namespace SandboxProject
{
    public class Person 
    {
            //get first name 
            public string _firstName;
            //get last name
            private string _lastName;

            public string firstName;

            public string lastName;

            public void SetFirstName(string newName)
            {
                _firstName = newName;
            }
            public string GetFirstName()
            {
                return _firstName;
            }
            public void SetLastName(string lastName)
            {
                _lastName = lastName;
            }
            public string GetLastName()
            {
                return _lastName;
            }

    }
}

