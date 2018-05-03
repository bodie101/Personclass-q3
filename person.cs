using System;

namespace qthree
{
    class Person 
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime DateOfBirth {get; set;}

        public Person(string firstName, string lastName, DateTime dob) {
            FirstName = firstName; 
            LastName = lastName; 
            DateOfBirth = dob; 
        }

        public string GetFullName() {
            return $"{FirstName} {LastName}"; 
        }

        public int GetAge() {

            var age =  DateTime.Now.Year - DateOfBirth.Year; 

            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear) {
                age = age - 1; 
            }
            return age; 
            }

            public string PersonInfo()
            {
                return $"Person: {GetFullName()} is {GetAge()} years old"; 
            } 
        }
    }
