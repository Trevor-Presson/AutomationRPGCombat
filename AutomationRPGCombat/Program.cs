using System;

namespace AutomationRPGCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //Seed Characters
            var characterGood = new Ranger { Name = "GoodJeff", Level = 1};
            var characterGoodAlly = new Ranger { Name = "JeffFriend", Level = 2 };
            var characterBad = new Warrior { Name = "EvilJeff", Level = 7};

            //Seed Item
            var barrel = new Item { Name = "Barrel", Health = 100 };

            //Seed Factions
            Faction factionGood = new Faction { Name = "GoodBoys" };
            Faction factionBad = new Faction { Name = "BadBoys" };

            //Join Factions
            characterGood.Factions.Add(factionGood);
            characterGoodAlly.Factions.Add(factionGood);
            characterBad.Factions.Add(factionBad);

            //Instantiate Combat
            var combat = new Combat();

            //Jeff kills barrel then heals self
            while (barrel.Health > 0)
            {
                combat.DealDamage(characterGood, barrel);
            }

            //Jeff's friend heals him
            combat.Heal(characterGood, characterGoodAlly);

            //Evil Jeff kills Good Jeff
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
