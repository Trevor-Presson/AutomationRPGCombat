using System;

namespace AutomationRPGCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Instance 
            var characterGood = new Ranger { Name = "GoodJeff", Level = 1 };

            var characterBad = new Warrior { Name = "EvilJeff", Level = 7 };

            var combat = new Combat();

            combat.Heal(characterGood, characterGood);

            while (characterGood.Alive == true)
            {
                if (combat.RangeCheck(characterBad, combat) == true)
                {
                    combat.DealDamage(characterBad, characterGood);
                }
            }



        }

        
    }
}
