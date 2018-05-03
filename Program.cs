using System;

namespace qthree
{
    class program 
    {
            
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
