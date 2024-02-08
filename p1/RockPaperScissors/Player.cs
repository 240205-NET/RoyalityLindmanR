namespace RockPaperScissors {

    abstract class Player {
        //fields
        public string name;
        

        //constructor
        public Player(){}
        public Player(string playerName) {
            this.name = playerName;
        }

        //methods
        public abstract string getName();
        

        // public int getlosses() {return losses;}
        // public void setlosses(int losses) {
        //     this.losses = losses;
        // }
        //public abstract void PlayGame();
    }
}