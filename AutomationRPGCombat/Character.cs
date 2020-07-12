using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace AutomationRPGCombat
{
    public abstract class Character
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public int Level { get; set; }
        public bool Alive { get; set; }
        public double Damage { get; set; }
        public abstract double Range { get; }

        public Character()
        {
            Health = 500;
            Level = 1;
            Alive = true;
            Damage = Level * 20;
        }
           
    }

    public class Ranger : Character
    {
        public override double Range => 25;
    }

    public class Warrior : Character
    {
        public override double Range => 2;
    }

}
