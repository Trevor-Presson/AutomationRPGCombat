using System;

namespace AutomationRPGCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Instance 
            var characterGood = new Character { Name = "GoodJeff" };

            var characterBad = new Character { Name = "EvilJeff" };


            var x = new Combat();

            x.Heal(characterGood, characterGood);

            while (characterGood.Alive == true)
            {
                x.DealDamage(characterBad, characterGood);
            }



        }

        
    }
}
