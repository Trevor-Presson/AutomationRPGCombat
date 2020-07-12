using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationRPGCombat
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; } 
        public int Level { get; set; }
        public bool Alive { get; set; }

        public Character()
        {
            Health = 500;
            Level = 1;
            Alive = true;
        }
        
        public void Heal(Character character)
        {
            if (character.Alive == true)
            {
                character.Health += 250;
                
                if (character.Health > 1000)
                {
                    character.Health = 1000;
                }
            }        
        }
    }
}
