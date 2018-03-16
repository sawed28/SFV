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
        public int Frame { get; set; }
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
                       Name = "Dragon Punch",
                       Frame = 13
                   },

                    new Move
                   {
                       Name = "Tatsu",
                       Frame = 20
                   }
                }

            };

            var ken = new Character
            {
                //Property
                Name = "Ken",

                //List
                MoveList = new List<Move>
                {
                   new Move
                   {
                       Name = "Dragon Punch",
                       Frame = 16
                   },

                    new Move
                   {
                       Name = "Tatsu",
                       Frame = 18
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
                       Name = "Dragon Punch",
                       Frame = 10
                   },

                    new Move
                   {
                       Name = "Tatsu",
                       Frame = 22
                   }
                }

            };

            //Add Characters to our List
            characterList.Add(akuma);
            characterList.Add(ken);
            characterList.Add(ryu);

            foreach (var character in characterList)
            {
                //Next Line
                Console.WriteLine("\n");

                //String Interpolation
                Console.WriteLine($"Name: {character.Name}");

                Console.WriteLine($"\nMoveList:\n");

                foreach (var move in character.MoveList)
                {
                    //String Interpolation
                    Console.WriteLine($"Move Name: {move.Name}  Move Frame: {move.Frame}");
                }
            };

            //Keeps Console Open
            Console.ReadLine();

        }
    }
}