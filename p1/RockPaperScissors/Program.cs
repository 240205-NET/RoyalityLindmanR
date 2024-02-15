using System;

namespace RockPaperScissors {
    public class Program {

        public static void Main(string[] args) {
            //create a game
            Game game = new Game();
            bool playing = true;

            //display opening for game
            Console.WriteLine(game.displayOpening());

            //call start game method
            game.StartGame();

            //game loop
            while (playing) {
                game.PlayGame();
                int choice = -1;

                //messaging to allow player to continue or quit
                Console.WriteLine("--------------------------");
                Console.WriteLine("Enter 1 to keep playing, 7 for rules, or 0 to end");

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
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("saving data");
                            // write to file
                            string[] text = game.SaveGame();
                            string path = @".\UserFile.txt";

                            File.WriteAllLines(path, text);

                            game.SaveGameOutput();

                            Console.WriteLine("game ending");
                            correctChoice = true;
                            playing = false;
                            break;
                        case 1:
                            Console.WriteLine("continuing...");
                            correctChoice = true;
                            break;
                        case 7:
                            Console.WriteLine(game.displayRules());
                            Console.WriteLine("choose 1 to continue, 7 for rules, or 0 to quit");
                            break;
                        default:
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("incorrect choice, choose 1 to continue, 7 for rules, or 0 to quit");
                            break;
                        }

                    }
            }
        }
    }
}