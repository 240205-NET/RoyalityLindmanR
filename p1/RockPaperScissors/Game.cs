namespace RockPaperScissors {
    public class Game {
        //fields
        List<User> userList = new List<User>();
        User? player1;
        Cpu? cpu;

        //constructor
        public Game() {}
        //method
        public void StartGame() {
            Console.WriteLine("Please enter a name");

            //create player and cpu
            string newName = Console.ReadLine();
            player1 = new User(newName);
            //could add player changed difficulty here
            cpu = new Cpu();

            //TODO add ability to write list to file/ read from file/ and check if name is on file

            Console.WriteLine("adding " + player1.name + " to user list");
            userList.Add(player1);

            Console.WriteLine(userList[0].name);
        }
        public void PlayGame() {
            int playerChoice = player1.playGame();
            int cpuChoice = cpu.playGame();

            if (playerChoice == cpuChoice) {
                Console.WriteLine("it's a draw");
            } else if (playerChoice == 1 && cpuChoice == 3) {
                //player wins
                Console.WriteLine("PLAYER wins");
                player1.wins += 1;
            } else if (cpuChoice == 1 && playerChoice == 3) {
                //cpu wins
                Console.WriteLine("CPU wins");
            }else if (playerChoice > cpuChoice) {
                //player wins
                Console.WriteLine("PLAYER wins");
                player1.wins += 1;
            } else {
                //cpu wins
                Console.WriteLine("CPU wins");
            }
            //Console.WriteLine("playerchoice = " + playerChoice + " ------ cpu choice " + cpuChoice);
        }
    }
}