using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffeCups = 0;

            Start:
            Console.WriteLine("Please enter your coffee size : $1 - Small, $2 - Medium, $3 - Large");
            int YourChoice = int.Parse(Console.ReadLine());

            switch (YourChoice)
            {
                case 1:
                    TotalCoffeCups += 1;
                    break;

                case 2:
                    TotalCoffeCups += 2;
                    break;

                case 3:
                    TotalCoffeCups += 3;
                    break;

                default:
                    Console.WriteLine("Your Order is invalid");
                    break;
            }

            Decision:
            Console.WriteLine("Do you want to more coffee : Yes or No?");
            string YourDecision = Console.ReadLine();

            switch (YourDecision.ToUpper())
            {
                case "YES":
                    goto Start;

                case "NO":
                    break;

                default:
                    Console.WriteLine("Your order is {0} invalid, Please try again ",YourDecision);
                    goto Decision;
            }

            Console.WriteLine("Thank you, Come Again!!!");
            Console.WriteLine("Your Amount is : ${0}", TotalCoffeCups);
            Console.ReadLine();
        }
    }
}
