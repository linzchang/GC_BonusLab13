using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab13
{
    class MagicUsingCharacter : GameCharacter
    {

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} has {Strength} strength, {Intelligence} intelligence, and {MagicalEnergy} magical energy.\n");
        }
    }
}
