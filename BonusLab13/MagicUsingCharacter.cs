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

        public override void Play(string name, int strength, int intelligence, string weaponType, int magicalEnergy, int spellNumber)
        {
            Console.WriteLine($"{name} has {strength} strength, {intelligence} intelligence, and {magicalEnergy} magical energy.");
        }
    }
}
