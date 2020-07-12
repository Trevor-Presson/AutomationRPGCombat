using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationRPGCombat
{
    public class Combat
    {
        public void DealDamage(Character attackingCharacter, Character defendingCharacter)
        {

            if (attackingCharacter.Name != defendingCharacter.Name)
            {
                defendingCharacter.Health -= 250;
            }
            
            if (defendingCharacter.Health <= 0)
            {
                defendingCharacter.Alive = false;
                Console.WriteLine("Character dead");
            }
        }

        public void Heal(Character healingCharacter, Character targetCharacter)
        {
            if (healingCharacter.Alive == true && healingCharacter.Name == targetCharacter.Name)
            {
                healingCharacter.Health += 250;

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
