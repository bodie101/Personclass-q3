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
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of new person below");
            Console.WriteLine("First Name: ");
            var fn = Console.ReadLine();

            Console.WriteLine("Last name: ");
            var ln = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Creating new person record....");

            Console.WriteLine();

            Console.WriteLine("Enter Year Of birth: dd/mm/yyyy");
            var dob = Console.ReadLine();
            var date = DateTime.Parse(dob); 

            Console.WriteLine();

            var pep = new Person(fn, ln, date);
           
            Console.WriteLine(); 
            Console.WriteLine(pep.PersonInfo()); 

             
        }
    }
}
