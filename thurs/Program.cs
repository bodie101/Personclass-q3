using System;

namespace thurs
{
    class Program
    {
        static void Main(string[] args)
        {
             var weekDayList = new List<string>();

            weekDayList.AddRange(weekDayList ); // {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

            Console.WriteLine(weekDayList.Count); // 7

            Console.WriteLine(weekDayList.Contains("Monday")); //True

            weekDayList.Clear(); // 

            Console.WriteLine(weekDayList.Count); // 0

            // Find the index of a weekday - Thursday
            Console.WriteLine($"Question 01: {weekDayList.IndexOf("Thursday")}");

            // Remove Wednesday and Thursday from the week
            weekDayList.RemoveRange(2, 2); 
            Console.WriteLine("Question 02: " + string.Join(",", weekDayList)); 


            // Sort the order of the weekdays in descending order
            weekDayList.sort();
            weekDayList.Reverse();
            Console.WriteLine("Question 03: " + string.Join(",", weekDayList));

            // Sort the order of weekdays from longest to shortest


        
        }
    }
}
