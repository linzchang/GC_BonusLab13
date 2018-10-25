using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab13
{
    class Wizard : MagicUsingCharacter
    {

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} is a wizard.  \n{Name} has {Strength} strength, {Intelligence} intelligence, and {MagicalEnergy} magical energy. \n{Name} knows {SpellNumber} spells.\n");
        }
    }
}
