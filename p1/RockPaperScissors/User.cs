namespace RockPaperScissors {
    class User : Player {
        //fields
        public int wins {get; set;}
        public int losses {get; set;}
        

        //constructor
        public User (string name, int wins = 0, int losses = 0) {
            this.name = name;
            this.wins = wins;
            this.losses = losses;
        }

        //methods

        public int getWins() {return this.wins;}
        public void setWins(int wins) {
            this.wins = wins;
        }

        public int playGame() {

            //set up
            Console.WriteLine("Please choose:");
            Console.WriteLine("1 for rock");
            Console.WriteLine("2 for paper");
            Console.WriteLine("3 for scissors");

            int choice = -1;
            bool correctChoice = false;

            while(!correctChoice) {
                // try to get input from user
                try {
                choice = Int32.Parse(Console.ReadLine());
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }

                // switch for user choices
                switch (choice) {
                    case 1:
                        Console.WriteLine("you chose rock");
                        correctChoice = !correctChoice;
                        return choice;
                    case 2:
                        Console.WriteLine("you chose paper");
                        correctChoice = !correctChoice;
                        return choice;
                    case 3:
                        Console.WriteLine("you chose scissors");
                        correctChoice = !correctChoice;
                        return choice;
                    default:
                        Console.WriteLine("incorrect choice, choose again");
                        break;
                }
            }
             return 0;
        }
    }
}