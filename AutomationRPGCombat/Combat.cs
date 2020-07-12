using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationRPGCombat
{
    public class Combat
    {
        public void DealDamage(Character attackingCharacter, Character defendingCharacter)
        {

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

        public void Heal(Character healingCharacter, Character targetCharacter)
        {
            //Logic - Restrict Healing to character that is alive and healing self
            if (healingCharacter.Alive == true && healingCharacter.Name == targetCharacter.Name)
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
