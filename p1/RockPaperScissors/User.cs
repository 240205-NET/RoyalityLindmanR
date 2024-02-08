namespace RockPaperScissors {
    class User : Player {
        //fields
        private int wins;
        private int losses;
        

        //constructor
        public User (string name) : base(name) {
            this.name = name;
        }

        //methods
        public override string getName() {return this.name;}

        public int getWins() {return this.wins;}
        public void setWins(int wins) {
            this.wins = wins;
        }

        //PlayGame();
    }
}