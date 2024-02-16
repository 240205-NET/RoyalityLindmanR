using System.Xml.Serialization;

namespace RockPaperScissors {
    public class Game {
        //fields
        //List<User> userList = new List<User>();
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
            //save player to file
            string[] text = {player1.toString()};
            string path = @".\UserFile.txt";

            string stringChoice = "";
            bool correctChoice = false;
            //write to file
            if(File.Exists(path)) {
                Console.WriteLine("file found");
                Console.WriteLine("--------------------------");
                //ask to override
                /*string[] readText = File.ReadAllLines(path);

                foreach (string s in readText) {
                    Console.WriteLine(s);
                }*/
                try {
                    Console.WriteLine((player1.Deserialize(path)).toString());
                    Console.WriteLine("is this you? y/n  (y to load data, n to create and override save data)");
                    while(!correctChoice) {
                        try {
                            stringChoice = Console.ReadLine();
                        } catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("--------------------------");

                        switch (stringChoice) {
                            case "y":
                                //deserialize object
                                player1 = player1.Deserialize(path);
                                Console.WriteLine("loading data for " + player1.name);
                                correctChoice = true;
                                break;
                            case "n":
                                Console.WriteLine("creating new data");
                                File.WriteAllLines(path, text);
                                Console.WriteLine("adding " + player1.name + " to file");
                                correctChoice = true;
                                break;
                            default:
                                Console.WriteLine("Invalid option, please type y or n");
                                break;

                        }
                    }
                    } catch (Exception e) {
                        Console.WriteLine("No compatible content");
                        File.WriteAllLines(path, text);
                        Console.WriteLine("adding " + player1.name + " to file");
                    }

                

            } else {
                File.WriteAllLines(path, text);
                Console.WriteLine("adding " + player1.name + " to file");
            }
        }

        public void PlayGame() {
            int playerChoice = player1.playGame();
            int cpuChoice = cpu.playGame();

            if (playerChoice == cpuChoice) {
                //draw
                Console.WriteLine("it's a draw");
                player1.draws += 1;

            } else if (playerChoice == 1 && cpuChoice == 3) {
                //player wins
                Console.WriteLine(player1.name + " wins");
                player1.wins += 1;

            } else if (cpuChoice == 1 && playerChoice == 3) {
                //cpu wins
                Console.WriteLine("CPU wins");
                player1.losses += 1;

            }else if (playerChoice > cpuChoice) {
                //player wins
                Console.WriteLine(player1.name + " wins");
                player1.wins += 1;

            } else {
                //cpu wins
                Console.WriteLine("CPU wins");
                player1.losses += 1;
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine(player1.toString());
            //Console.WriteLine("playerchoice = " + playerChoice + " ------ cpu choice " + cpuChoice);
        }
        public string[] SaveGame() {
        
            /*var stringWriter = new StringWriter();
            Serializer.Serialize(stringWriter, player1);
            stringWriter.Close();*/

        
            string[] text = {player1.SerializeXML()};
            return text;
        }

        public void SaveGameOutput() {
            User u = new User();
            string path = @".\UserFile.txt";
            XmlSerializer Serializer = new XmlSerializer(typeof(User));


            if(!File.Exists(path)) {
                Console.WriteLine("file not found");
                return;
            } else {
                using StreamReader reader = new StreamReader(path);
                var record = (User)Serializer.Deserialize(reader);
                if(record is null) {
                    throw new InvalidDataException();
                    //return;
                } else {
                    u = record;
                }
                
                //ending output
                Console.WriteLine("Name: " + u.name);
                Console.WriteLine("Wins: " + u.wins);
                Console.WriteLine("losses: " + u.losses);
                Console.WriteLine("draws: " + u.draws);
                
            }
            
        }
        public string displayOpening() {
            string opening = "*-------------------------------*\n*-*Welcome to Console Fighter*-*\n*-------------------------------*";
            return opening;
        }
        public string displayRules() {
            string rules = "*----------------------------------------------*\n*--------------------Rules---------------------*\n*-Press 1 for low. Low beats high attacks------*\n*-Press 2 for medium. Medium beats low attacks-*\n*-Press 3 for high. High beats medium attacks--*\n*----------------------------------------------*";
            return rules;
        }
    }
}