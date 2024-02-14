using System.Xml.Serialization;

namespace RockPaperScissors {
    public class User : Player {
        //fields
        public int wins {get; set;}
        public int losses {get; set;}
        public int draws {get; set;}
        private XmlSerializer Serializer = new XmlSerializer(typeof(User));

        //constructor
        public User() {}
        public User (string name, int wins = 0, int losses = 0, int draws = 0) {
            this.name = name;
            this.wins = wins;
            this.losses = losses;
            this.draws = draws;
        }
        

        //methods

        // public int getWins() {return this.wins;}
        // public void setWins(int wins) {
        //     this.wins = wins;
        // }
        public override string toString()
        {
            return $"Player\nName: {this.name}\nWins: {this.wins}\nLosses: {this.losses}\nDraws: {this.draws}\n";
        }

        public int playGame(int choice = -1) {

            //set up
            Console.WriteLine("--------------------------");
            Console.WriteLine("Please choose:");
            Console.WriteLine("1 for rock");
            Console.WriteLine("2 for paper");
            Console.WriteLine("3 for scissors");

            //int choice = -1;
            bool correctChoice = false;

            while(!correctChoice) {
                // try to get input from user
                try {
                choice = Int32.Parse(Console.ReadLine());
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("--------------------------");

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
                        Console.WriteLine("incorrect choice, choose 1 for rock, 2 for paper, 3 for scissors");
                        break;
                }
            }
             return 0;
        }

        public string SerializeXML()
        {
            var stringWriter = new StringWriter();
            Serializer.Serialize(stringWriter, this);
            stringWriter.Close();
            return stringWriter.ToString();
        }
        public User Deserialize(string path) {
            User u = new User();
            if(!File.Exists(path)) {
                Console.WriteLine("file not found");
                return null;
            } else {
                using StreamReader reader = new StreamReader(path);
                var record = (User)Serializer.Deserialize(reader);
                if(record is null) {
                    throw new InvalidDataException();
                    return null;
                } else {
                    u = record;
                }
                return u;
            }
            
        }

    }
}