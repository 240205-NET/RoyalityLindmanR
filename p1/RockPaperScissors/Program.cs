using System;

namespace RockPaperScissors {
    public class Game {

        public static void Main(string[] args) {
            Console.WriteLine("Please enter a name");

            string newName = Console.ReadLine();
            Player jim = new User(newName);

            Console.WriteLine(jim.getName());

        }
    }
}