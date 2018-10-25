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

        public override void Play()
        {
            Console.WriteLine($"{Name} is a warrior with {Strength} strength and {Intelligence} intelligence. \n{Name} wields a {WeaponType}.\n");
        }

    }
}
