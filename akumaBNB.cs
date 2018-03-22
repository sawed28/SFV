using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akumaBNB
{
    //Character Class
    public class Character
    {
        public string Name { get; set; }

        //A List of Moves for Character
        public List<Move> MoveList { get; set; }
    }

    //Move class
    public class Move
    {
        public string Name { get; set; }
        //public int Frame { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Set app vars
            string appName = "Street Fighter V Combo / Mixup guide";
            string appVersion = "1.0.0";
            string appAuthor = "Francis Harris & Brenton Bates";

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Create Empty Character List
            List<Character> characterList = new List<Character>();

            //Create Characters
            var akuma = new Character
            {
                //Property
                Name = "Akuma",

                //List
                MoveList = new List<Move>
                {
                    new Move
                   {
                       Name = "Punish Combo 1 (CC)S.HK,C.HP,S.MK XX V-SKILL K XX QCB LK, DP HP",
                       //Frame = 13
                   },

                    new Move
                   {
                       Name = "Punish Combo 2 (CC)S.HK,C.HP,S.MK XX QCB LK, DP HP / QCB HK",
                       //Frame = 20
                   },

                    new Move
                    {
                        Name = "Punish Combo 3 (CC) HK, C.HP,S.MK XX V-SKILL K XX HCF K, P",
                    },

                    new Move
                    {
                        Name = "Punish Combo 4 (CC)C.HP, S.MK XX V-SKILL K XX QCB LK, DP HP",
                    },

                    new Move
                    {
                        Name = "Punish Combo 5 (FAR)(CC) C.HP. DASH, B+HP XX HCB HP",
                    },

                    new Move
                    {
                        Name = "Punish Combo 6 (FAR)(CC) C.HP, DASH, B+HP XX HCF HK, P",
                    },

                    new Move
                    {
                        Name = "Punish Combo 7 (FAR)(CC) C.HP, DASH, B+HP XX HCB HP XX CA",
                    },

                    new Move
                    {
                        Name = "Mixup with V-Trigger (Raging Demon) - C.MP,S.MK,QCB LK, Crouch MP, HP+HK (V-Trigger), LP,LP,F LK, HP",
                    },

                    new Move
                    {
                        Name = "Mixup with V-Trigger (Raging demon) - On knock down and in V-Trigger do QCF LK (Opponent blocks) LP,LP,F LK, HP",
                    },

                    new Move
                    {
                        Name = "S.MP / C.MP, S.MK, QCB LK, D.MP (for flip out) LP, LP, F LK, HP",
                    },

                    new Move
                    {
                        Name = "(Corner Pessure) (Pressure Anywhere) S.LK, S.LK, S.MK, C.HP for (CC), DASH B.HP, HCF HK XX P / HCB HP buffer CA and execute on first hit of fireball / CA ",
                    },

                    new Move
                    {
                        Name = "Mixup VS Cammy's crouch MP - S.MK (Onblock) (Cammy does D.MP) - (She will now get hit if she presses a button) Do C.HP for (CC), DASH, B.HP, QCF HK XX P (This mixup does not work if you are cornered)",
                    },

                    new Move
                    {

                        Name = "Mixup VS Cammy's crouch MP - S.MK (Onblock) (Cammy does D.MP) - (She will now get hit if she presses a button) Do C.HP for (CC), DASH, B.HP, QCB HP, buffer CA and execute on first hit of fireball (This mixup does not work if you are cornered)",
                    },

                    new Move
                    {
                        Name = "Mixup VS Cammy's crouch MP - S.MK (Onblock) (Cammy does D.MP) - (She will now get hit if she presses a button) Do C.HP for (CC), DASH, QCB LK, FDF HP, HP+HK (V-Trigger), QCF HK, QCF LP, Jump forward (as fireballs hit you will be on the other side) S.MK, Down HP, DASH, B.HP, QCF HK XX P",
                    },

                    new Move
                    {
                        Name = "Mixup VS Cammy's crouch MP - S.MK (Onblock) (Cammy does D.MP) - (She will now get hit if she presses a button) Do C.HP for (CC), DASH, QCB LK, FDF HP, HP+HK (V-Trigger), QCF HK, QCF LP, Jump forward (as fireballs hit you will be on the other side) S.MK, Down HP, DASH, B.HP, QCB HP, buffer CA and execute on first hit of fireball",

                    },

                    new Move
                    {
                        Name = "Mixup VS Urien's crouch MP - C.LP, C.MP, S.MK, QCB LK, HCB HK / FDF HP"
                    },

                    new Move
                    {
                        Name = "Mixup VS Urien's crouch MP (Raging Demon) - C.LP, C.MP, S.MK, QCB LK, C.MP, HP+HK (V-Trigger), LP, LP, F LK, HP",
                    },

                    new Move
                    {
                        Name = "Mixup VS Urien's crouch MP - S.MP, S.LP, HCB MK",
                    },

                    new Move
                    {
                        Name = "Mixup VS Urien's crouch MP - HCF LK XX P, C.LP, C.MP, HCF HP",
                    },

                    new Move
                    {
                        Name = "Mixup VS Urien's crouch MP - Jump forward HP, C.HP (CC), B.HP, CA (Corner) (Anywhere)",
                    },

                    new Move
                    {
                        Name = "Mixup VS Urien's crouch MP - Jump forward HP, C.HP (CC), B.HP, QCB HP, buffer ca and execute on first hit",
                    },

                    new Move
                    {
                        Name = "Mixup VS Urien's crouch MP (Raging Demon) - (Close) S.MK, QCF HP, HP + HK (V-Trigger) LP, LP, F LK, HP",
                    }
                }
            };

            var blanka = new Character
            {
                //Property
                Name = "blanka",

                //List
                MoveList = new List<Move>
                {
                   new Move
                   {
                       Name = "Hit Confirm 1 - C.LK, C.LP XX D-U MK * (* = Can be canceled into critical art)",
                       //Combos with D-U can also be ended with b+f P
                   },

                    new Move
                   {
                       Name = "Hit Confirm 2 - C.LP, C.LP XX B-F HP * ",
                       //Frame = 18
                   },

                    new Move
                    {
                        Name = "Hit Confirm 3 - C.LP, S.LK, C.LP XX B-F HP * ",
                    },

                    new Move
                    {
                        Name = "Hit Confirm 4 - S.LK, S.LK, C.LP XX B-F HP * ",
                    },

                    new Move
                    {
                        Name = "Hit Confirm 5 - S.MK-HK-HP",
                    },

                    new Move
                    {
                        Name = "Hit Confirm 6 - C.MK, C.LP, XX D-U MK * ",
                    },

                    new Move
                    {
                        Name = "Hit Confirm 7 - S.HP, XX VS+P, D-U MK * ",
                    },

                    new Move
                    {
                        Name = "Hit Confirm 8 - S.HP XX VS+P, DF.HP ",
                    },

                    new Move
                    {
                        Name = "Hit Confirm 9 - C.HP XX CA ",
                    },

                    new Move
                    {
                        Name = "Jump in 1 - J.HK, S.HP XX VS+P D-U MK ",
                    },

                    new Move
                    {
                        Name = "Jump in 2 - J.HK, S.HP, XX VS+P [DELAY] D-U LK, XX CA ",
                    },

                    new Move
                    {
                        Name = "Jump in 3 - J.MK, C.MK, C.LP XX D-U MK * ",
                    },

                    new Move
                    {
                        Name = "Counter Hit - To be continued... ",
                    },
                }

            };

            /*
            var ryu = new Character
            {
                //Property
                Name = "Ryu",

                //List
                MoveList = new List<Move>
                {
                   new Move
                   {
                       //Name = 
                       //Frame = 10
                   },

                    new Move
                   {
                       Name = "Tatsu",
                       //Frame = 22
                   }
                }

            };
            */

            //Add Characters to our List
            characterList.Add(akuma);
            characterList.Add(blanka);
            //characterList.Add(ryu);

            foreach (var character in characterList)
            {
                //Next Line
                Console.WriteLine("\n");

                //String Interpolation
                Console.WriteLine($"Name: {character.Name}");

                Console.WriteLine($"\nMoveList:\n");

                foreach (var move in character.MoveList)
                {
                    Console.Write("\n");
                    //String Interpolation
                    Console.WriteLine($"Move Name: {move.Name} ");
                    //Move Frame: {move.Frame}");
                }
            };

            //Keeps Console Open
            Console.ReadLine();

            


        }
    }
}