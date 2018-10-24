using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab13
{
    class Warrior : GameCharacter
    {
        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override void Play(string name, int strength, int intelligence, string weaponType, int magicalEnergy, int spellNumber)
        {
            Console.WriteLine($"{name} is a warrior.  {name} has {strength} strength, {intelligence} intelligence, and uses a {WeaponType}.");
        }

    }
}
