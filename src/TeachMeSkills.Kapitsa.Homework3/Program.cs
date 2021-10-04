using System;

namespace TeachMeSkills.Kapitsa.Homework3
{
    class Program
    {
        static void testOfDay()
        {
            Console.WriteLine("Insert a day week in English, please:");
            string userDayOfWeek = Console.ReadLine();
            switch (userDayOfWeek)
            {
                case "Monday":
                    Console.WriteLine("You insert: Monday.");
                    break;
                case "Tuesday":
                    Console.WriteLine("You insert: Tuesday.");
                    break;
                case "Wednesday":
                    Console.WriteLine("You insert: Wednesday.");
                    break;
                case "Thursday":
                    Console.WriteLine("You insert: Thursday.");
                    break;
                case "Friday":
                    Console.WriteLine("You insert: Friday.");
                    break;
                case "Saturday":
                    Console.WriteLine("You insert: Saturday.");
                    break;
                case "Sunday":
                    Console.WriteLine("You insert: Sunday.");
                    break;
                default:
                    Console.WriteLine("You insert incorrect value");
                    break;
            }
            if (answewAnalyzer() == true)
            {
                testOfDay();
            }
            else
            {
                Console.WriteLine("Thank you!");
            }
        }
        static bool answewAnalyzer()
        {
            bool answer;
            Console.WriteLine("If you want to make one more test type: Y\nOtherwise press any button.");
            string answerToContinue = Console.ReadLine();
            switch (answerToContinue)
            {
                case ("Y"):
                    answer = true;
                    break;
                case ("y"):
                    answer = true;
                    break;
                default:
                    answer = false;
                    break;
            }
            return answer;
        }
        static void Main()
        {
            Console.WriteLine("Hometask 3.");
            testOfDay();
        }

    }
}
