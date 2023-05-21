using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string email;
        public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    if (value.Contains("@") && value.EndsWith(".com"))
                    {
                        email = value;
                    }
                    else
                        Console.WriteLine("Wrong value");
                }
            }
            public string GetFullName()
            {
                return firstName + " " + lastName;

            }
            public void Print()
            {
                Console.WriteLine($"Name : {GetFullName()},Email :{email}");
            }
        }
    }
