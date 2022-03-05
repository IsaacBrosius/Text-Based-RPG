/*using System;
using System.Windows;

namespace Calculator {

    class Program2 {

        static void Main(string[] args) {

            Console.ForegroundColor = ConsoleColor.Green;

            double num1;
            double num2;

            string mayNum1;
            string mayNum2;

            Console.Title = "Noob's Second Console";

            void restart() {
                Console.Clear();

                Console.WriteLine("Input a number: ");

                mayNum1 = Console.ReadLine();

                bool success1 = double.TryParse(mayNum1, out num1);

                if (success1 == false) {

                    Console.WriteLine("That's not a number");

                    Console.WriteLine("\nPress Enter to restart.");
                    string space2 = Console.ReadLine().ToString();

                    if (space2 == "") {
                        restart();
                    }

                }

                Console.WriteLine("Input a second number: ");

                mayNum2 = Console.ReadLine();

                bool success2 = double.TryParse(mayNum2, out num2);

                if (success2 == false) {

                    Console.WriteLine("That's not a number.");

                    Console.WriteLine("\nPress Enter to restart.");
                    string space2 = Console.ReadLine().ToString();

                    if (space2 == "") {
                        restart();
                    }

                }

                double result = num1 * num2;

                Console.WriteLine("\n****" + result + "****\n");

                Console.WriteLine("What did it do? \nA: Add \nB: Subtract \nC: Multiply \nD: Divide \nE: Magic \nF: Drugs \nG: Other (Type out)");

                string guess = Console.ReadLine();

                string guessNum;

                string ask;

                if (guess == "C" || guess == "c" || guess == "multiply" || guess == "Multiply") {
                    Console.WriteLine("Ding Ding Ding! Bell of Smartness!");
                }

                else if (guess == "E" || guess == "e" || guess == "Magic" || guess == "magic") {
                    Console.WriteLine("Avada Kadabra! You are dead now. You cannot know the ways of this program.");
                }

                else if (guess == "F" || guess == "f" || guess == "Drugs" || guess == "drugs") {

                    Console.WriteLine("Hahaha. I like where your brain went. Was this your first guess?");

                    guessNum = Convert.ToString(Console.ReadLine());

                    if (guessNum == "Yes" || guessNum == "yes" || guessNum == "Yeah" || guessNum == "yeah" || guessNum == "Yep" || guessNum == "yep" || guessNum == "Yah" || guessNum == "yah") {

                        Console.WriteLine("Are you lying?");
                        ask = Convert.ToString(Console.ReadLine());

                        if (ask == "Yes" || ask == "yes" || ask == "Yeah" || ask == "yeah" || ask == "Yep" || ask == "yep" || ask == "Yah" || ask == "yah") {
                            
                            Console.WriteLine("I am disapointed in you.");

                        }

                        else if (ask == "No" || ask == "no" || ask == "Nope" || ask == "nope" || ask == "Nah" || ask == "nah") {

                            Console.WriteLine("Are you lying again?");
                            string ask2 = Console.ReadLine().ToString();

                            if (ask2 == "Yes" || ask2 == "yes" || ask2 == "Yeah" || ask2 == "yeah" || ask2 == "Yep" || ask2 == "yep" || ask2 == "Yah" || ask2 == "yah") {
                            
                            Console.WriteLine("I am disapointed in you.");

                            }

                            else if (ask2 == "No" || ask2 == "no" || ask2 == "Nope" || ask2 == "nope" || ask2 == "Nah" || ask2 == "nah") {

                                Console.WriteLine("Are you sure?");

                                string ask3 = Console.ReadLine().ToString();

                                if (ask3 == "Yes" || ask3 == "yes" || ask3 == "Yeah" || ask3 == "yeah" || ask3 == "Yep" || ask3 == "yep" || ask3 == "Yah" || ask3 == "yah") {

                                    Console.WriteLine("Are you positive?");      

                                    string ask4 = Console.ReadLine().ToString();                          

                                    if (ask4 == "Yes" || ask4 == "yes" || ask4 == "Yeah" || ask4 == "yeah" || ask4 == "Yep" || ask4 == "yep" || ask4 == "Yah" || ask4 == "yah") {

                                        Console.WriteLine("Only fools are positive.");

                                    }

                                    else if (ask4 == "No" || ask4 == "no" || ask4 == "Nope" || ask4 == "nope" || ask4 == "Nah" || ask4 == "nah" ||ask4 == "HIV" || ask4 == "hiv") {

                                        Console.WriteLine("Right answer.");

                                    }

                                }

                                else if (ask3 == "No" || ask3 == "no" || ask3 == "Nope" || ask3 == "nope" || ask3 == "Nah" || ask3 == "nah") {

                                    Console.WriteLine("Why not?");
                                    
                                    Console.ReadLine();

                                    Console.WriteLine("I don't care.");

                                }
                            
                            }

                        }
                    }

                    else if (guessNum == "No" || guessNum == "no" || guessNum == "Nope" || guessNum == "nope" || guessNum == "Nah" || guessNum == "nah") {

                        Console.WriteLine("I am disapointed in you.");

                    }

                    else {
                        Console.WriteLine("Why didn't you put a normal answer?");
                    }
                }

                else if (guess == "Your Mom" || guess == "Your mom" || guess == "your mom" || guess == "ur mom") {
                    Console.WriteLine("Wow. Real genius right there. /s");
                }

                else {
                    Console.WriteLine("Nope. Try again.");
                }

                Console.WriteLine("\nPress Enter to restart.");
                string space = Console.ReadLine().ToString();

                if (space == "") {
                    restart();
                }
                
            }

            restart();

            Console.ReadKey();
        }

    }

}*/


