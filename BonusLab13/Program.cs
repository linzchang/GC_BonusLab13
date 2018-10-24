using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab13
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter warrior1 = new Warrior("The Black Knight", 900, 10, "sword");
            GameCharacter warrior2 = new Warrior("Leeroy Jenkins", 800, 3, "sword");
            GameCharacter wizard1 = new Wizard("Gandalf", 900, 900, 900, 90);
            GameCharacter wizard2 = new Wizard("Albus Dumbledore", 800, 900, 900, 100);
            GameCharacter wizard3 = new Wizard("Harry Potter", 500, 400, 600, 60);

            GameCharacter[] gameCharacters = new GameCharacter[] {
                 warrior1, warrior2, wizard1, wizard2, wizard3
            };

            foreach (GameCharacter character in gameCharacters)
            {
                character.Play(character.Name, character.Strength, character.Intelligence, character.WeaponType,
                    character.MagicalEnergy, character.SpellNumber);
            }

            Console.ReadLine();
        }
    }
}
