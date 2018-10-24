﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab13
{
    class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public string WeaponType { get; set; }
        public int MagicalEnergy { get; set; }
        public int SpellNumber { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public virtual void Play(string name, int strength, int intelligence, string weaponType, int magicalEnergy, int spellNumber)
        {
            Console.WriteLine($"{name} has {strength} strength and {intelligence} intelligence.");
        }
    }
}
