//greet the player
using System.Security.Cryptography;
using System;

namespace GuessingGame{
    public class GG {
        public static void Main(string[] args) {
            Console.WriteLine("yoyoyo, checkitout!!");

            // randomly generated number (for the player to guess)
            //var rand = new Random();
            Random rand = new Random();

            //uint (unsigned int) 0-2 bill
            // int (signed int) -1 bill - 1 bill
            int target = rand.Next(21); //generate an integer value from 0-20

            // remove for production
            Console.WriteLine(target);

            // something to show if player has won
            // boolean value to represent 
            bool win = false;
            int i = 0;
            //declare and set default guess value
            int guess = -1;

            // loop to keep guessing until the player guesses correctly
            while (!win) { // C# comparison operators ==, >, <, >=, <=, !=
            // accept the input
            Console.WriteLine("Make a guess between 0 and 20, YE COWARD!!!!!");
                // accept user input, typechange, and store in numerical var

                //handle possibility of bad input
                try {
                    guess = Int32.Parse(Console.ReadLine());
                    if(guess >= 0 && guess <= 20) { // C# logical operators: &&, || (AND, OR)
                        if (guess == target) {
                            Console.WriteLine("YIPEEEEE");
                            win = true;
                                // if they're wrong prompt to guess again
                        } else if (guess > target) {
                            //too high
                            Console.WriteLine("TOO HIGH MATEY");
                        } else {
                            Console.WriteLine(" TOO LOWWWW,WALK THE PLAAANK");
                        }
                        i++;
                        Console.WriteLine("AVAST YEE, Attempt #: " + i);
                        } else {
                            Console.WriteLine("Your guess was out of range");
                        }
                } catch(Exception e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("value entered HAD SCURVY, TRY AGAAAIN");
                }
            // checks if the player has guessed the correct number
            


            }

        Console.WriteLine("YEE WON MATEY AT " + i + " ATTEMPTS");
        //prompt to play again
            //if no exit the program
            //if yes, play again
        }
    }
}

