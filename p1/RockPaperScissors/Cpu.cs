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
            int randomNum = rd.Next(1,4);

            switch (randomNum) {
                case 1:
                    Console.WriteLine("cpu chose low attack");
                    break;
                case 2:
                    Console.WriteLine("cpu chose medium attack");
                    break;
                case 3:
                    Console.WriteLine("cpu chose high attack");
                    break;
            }
            return randomNum;
        }
    }
}