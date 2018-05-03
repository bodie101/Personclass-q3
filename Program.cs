using System;

namespace qthree
{
    class program 
    {
            
        static void Main(string[] args)
        {
            //Asking if the user to enter person details

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

            //Putting the values from var pep and putting them in PersonInfo

            var pep = new Person(fn, ln, date);
           
            Console.WriteLine(); 
            Console.WriteLine(pep.PersonInfo());


            //Question 3b

            Console.WriteLine("Do you want to add another person"); 

            var adduser = false;  

            do{ 

                //Conditions for if the user presses y or n 

                Console.WriteLine("Would you like to add another user? (y/n) ");
                var yesAdd = Console.ReadLine();

                if (yesAdd == "y") {
                    adduser = true;
                    AddUser();
                } else {
                    //ending program if (n) is typed
                    Console.WriteLine("Thank you, press any key to exit");  
                    adduser = false; 
                    Console.ReadKey();
                } 
            }while(adduser);
        }    
            

            //If the user wants to add another user
            static void AddUser() {

                Console.WriteLine("First Name: ");
                var fn = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Last Name: "); 
                var ln = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("What is your date of birth (dd/mm/yyyy");
                var dob = Console.ReadLine();
                var date = DateTime.Parse(dob);
                Console.WriteLine();

                var person = new Person(fn, ln, date);
                Console.WriteLine();

                Console.WriteLine(person.PersonInfo());
                Console.WriteLine();

            

             }
        }
    }
        
    

