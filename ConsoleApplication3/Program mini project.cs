using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3 //Project name
{
    class Program //Name of your class
    {
        static void Main(string[] args) //Starting point of any program
        {

            int choice;
            do
            {
                float weightonearth;
                double result;
                Console.WriteLine("\n");
                Console.WriteLine("Menu of Planets");
                Console.WriteLine("==== == =======");
                Console.WriteLine("1.Jupiter   2.Mars    3.Mercury");
                Console.WriteLine("4.Neptune   5.Pluto   6.Saturn");
                Console.WriteLine("7.Uranus    8.Venus   9.<Quit>");
                Console.WriteLine("\n");

                do
                {
                    Console.Write(" Enter your menu choice = ");
                    choice = int.Parse(Console.ReadLine()); // choice is a integer that stores a function/method
                } while (choice <= 0 || choice > 9);//statements execute as long as the variable choice is between 1 to 9

                if (choice == 9) // if statements execute a boolean result; that is, true
                {
                    Console.WriteLine("Have a great !. Goodbye!");
                    Console.ReadLine();
                }

                do
                {
                    Console.Write(" Enter your weight on earth = ");

                    weightonearth = float.Parse(Console.ReadLine());

                } while (weightonearth <= 0); // statements execute as long as the variable weightonearth is less than or equal to 0



                switch (choice) // statement that selects a switch section to execute from a list of cases
                {
                    case 1:
                        result = Math.Round((weightonearth * 2.64), 1);
                        Console.WriteLine(" your Weight of " + weightonearth + " pounds on the Earth would be " + result + " puonds on  Jupiter");
                        break;

                    case 2:
                        result = Math.Round((weightonearth * 0.38), 1);
                        Console.WriteLine(" your Weight of " + weightonearth + " pounds on the Earth would be " + result + " puonds on  Mars");
                        break;

                    case 3:
                        result = Math.Round((weightonearth * 0.37), 1);
                        Console.WriteLine(" your Weight of " + weightonearth + " pounds on the Earth would be " + result + " pounds on Mercury");
                        break;

                    case 4:
                        result = Math.Round((weightonearth * 1.15), 1);
                        Console.WriteLine(" your Weight of " + weightonearth + " pounds on the Earth would be " + result + " puonds on  Neptune");
                        break;

                    case 5:
                        result = Math.Round((weightonearth * 0.04), 1);
                        Console.WriteLine(" your Weight of " + weightonearth + " pounds on the Earth would be " + result + " puonds on  Pluto");
                        break;

                    case 6:
                        result = Math.Round((weightonearth * 1.15), 1);
                        Console.WriteLine(" your Weight of " + weightonearth + " pounds on the Earth would be " + result + " puonds on  Saturn");
                        break;

                    case 7:
                        result = Math.Round((weightonearth * 1.15), 1);
                        Console.WriteLine(" your Weight of " + weightonearth + " pounds on the Earth would be " + result + " puonds on  Uranus");
                        break;

                    case 8:
                        result = Math.Round((weightonearth * 0.88), 1);
                        Console.WriteLine(" your Weight of " + weightonearth + " pounds on the Earth would be " + result + " puonds on  Venus");
                        break;

                }
            }
            while (choice != 9); // statements execute as long as whole prosses until the vaiable of choice = 9
        }
    }
}
