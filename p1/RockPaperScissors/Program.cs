using System;

namespace RockPaperScissors {
    public class Program {

        public static void Main(string[] args) {
            //create a game
            Game game = new Game();
            bool playing = true;

            //call start game method
            game.StartGame();

            //game loop
            while (playing) {
                game.PlayGame();
                int choice = -1;

                //messaging to allow player to continue or quit
                Console.WriteLine("--------------------------");
                Console.WriteLine("Enter 1 to keep playing or 0 to end");

                bool correctChoice = false;

                while(!correctChoice) {
                    //try to get user input
                    try {
                    choice = Int32.Parse(Console.ReadLine());
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }

                    //switch for user choices
                    switch (choice) {
                        case 0:
                            Console.WriteLine("game ending");
                            correctChoice = true;
                            playing = false;
                            break;
                        case 1:
                            Console.WriteLine("continuing...");
                            correctChoice = true;
                            break;
                        default:
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("incorrect choice, choose 1 to continue or 0 to quit");
                            break;
                        }

                    }
            }
        }
    }
}