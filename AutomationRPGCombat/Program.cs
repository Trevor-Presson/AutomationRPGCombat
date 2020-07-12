using System;

namespace AutomationRPGCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Instance 
            var characterGood = new Character { Name = "GoodJeff", Level = 1 };

            var characterBad = new Character { Name = "EvilJeff", Level = 7 };


            var x = new Combat();

            x.Heal(characterGood, characterGood);

            while (characterGood.Alive == true)
            {
                x.DealDamage(characterBad, characterGood);
            }



        }

        
    }
}
