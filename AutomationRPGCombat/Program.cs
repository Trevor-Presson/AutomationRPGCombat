using System;

namespace AutomationRPGCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Instance 
            var characterGood = new Ranger { Name = "GoodJeff", Level = 1};
            var characterGoodAlly = new Ranger { Name = "JeffFriend", Level = 2 };

            var characterBad = new Warrior { Name = "EvilJeff", Level = 7};

            //Join Faction 
            Faction factionGood = new Faction { Name = "GoodBoys" };
            Faction factionBad = new Faction { Name = "BadBoys" };

            characterGood.Factions.Add(factionGood);
            characterGoodAlly.Factions.Add(factionGood);
            characterBad.Factions.Add(factionBad);

            var combat = new Combat();

            combat.Heal(characterGood, characterGoodAlly);

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
