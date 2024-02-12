namespace RockPaperScissors {
    public class Cpu : Player {
        //fields
        int difficulty = 0;
        Random rd = new Random();

        //constructor
        public Cpu () {}

        public override string toString()
        {
            return "Cpu";
        }

        //methods
        public int playGame() {
            //difficulty 0
            int randomNum = rd.Next(1,3);

            switch (randomNum) {
                case 1:
                    Console.WriteLine("cpu chose rock");
                    break;
                case 2:
                    Console.WriteLine("cpu chose paper");
                    break;
                case 3:
                    Console.WriteLine("cpu chose scissors");
                    break;
            }
            return randomNum;
        }
    }
}