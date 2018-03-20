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
                }
            };

            /*var ken = new Character
            {
                //Property
                Name = "Ken",

                //List
                MoveList = new List<Move>
                {
                   new Move
                   {
                       Name = "Dragon Punch",
                       //Frame = 16
                   },

                    new Move
                   {
                       Name = "Tatsu",
                       //Frame = 18
                   }
                }

            };


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
            /*characterList.Add(ken);
            characterList.Add(ryu);*/

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