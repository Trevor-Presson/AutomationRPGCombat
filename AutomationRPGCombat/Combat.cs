using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationRPGCombat
{
    public class Combat
    {
        public double CombatRange { get; set; }

        public Combat()
        {
            CombatRange = 100;
        }

        public bool RangeCheck (Character attackingCharacter, Combat combat )
        {
            if (attackingCharacter.Range >= combat.CombatRange)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient distance... currently {0} feet away", combat.CombatRange);
                combat.CombatRange -= 10;
                return false;
            }
        }

        public void DealDamage(Character attackingCharacter, Character defendingCharacter)
        {

            //Logic - Cannot damage ally in faction 
            if (attackingCharacter.Factions.Any(x => defendingCharacter.Factions.Any(y => y == x)))
            {
                Console.WriteLine("Cannot attack ally");
            }

            else {
                //Logic to set Damage 
                if ((attackingCharacter.Level - defendingCharacter.Level) >= 5)
                {
                    attackingCharacter.Damage += (attackingCharacter.Damage * .5);
                }
                else if ((attackingCharacter.Level - defendingCharacter.Level) >= 5)
                {
                    attackingCharacter.Damage -= attackingCharacter.Damage - (attackingCharacter.Damage * .5);
                }

                //Logic - Prevent Damage dealt to self
                if (attackingCharacter.Name != defendingCharacter.Name)
                {
                    defendingCharacter.Health -= attackingCharacter.Damage;
                }

                //Logic - Assign Death if Health drops to 0 or below 
                if (defendingCharacter.Health <= 0)
                {
                    defendingCharacter.Alive = false;
                    Console.WriteLine("Character dead");
                }
            }
        }

        public void DealDamage(Character attackingCharacter, Item item)
        {
            item.Health -= attackingCharacter.Damage;

            if (item.Health <= 0)
            {
                Console.WriteLine("Item is destroyed");
            }
        }

        public void Heal(Character healingCharacter, Character targetCharacter)
        {
            //Logic - Restrict Healing to character that is alive and healing self
            if (healingCharacter.Alive == true && healingCharacter.Factions.Any(x => targetCharacter.Factions.Any(y => y == x)))
            {
                healingCharacter.Health += 250;

                //Logic - Prevent healing > 1000
                if (healingCharacter.Health > 1000)
                {
                    healingCharacter.Health = 1000;
                }
            }

            else
            {
                Console.WriteLine("You cannot heal someone else");
            }
        }
    }
}
