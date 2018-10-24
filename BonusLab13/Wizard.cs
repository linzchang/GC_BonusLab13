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

        public override void Play(string name, int strength, int intelligence, string weaponType, int magicalEnergy, int spellNumber)
        {
            Console.WriteLine($"{name} is a wizard.  {name} has {strength} strength, {intelligence} intelligence, and {magicalEnergy} magical energy. {name} knows {spellNumber} spells.");
        }
    }
}
