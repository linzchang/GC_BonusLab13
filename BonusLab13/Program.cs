using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

            List<GameCharacter> gameCharacters = new List<GameCharacter> {
                 warrior1, warrior2, wizard1, wizard2, wizard3
            };

            Console.WriteLine("Welcome to the Character generator!");
            MainMenu(gameCharacters);
        }

        public static void MainMenu(List<GameCharacter> gameCharacters)
        {
            while (true)
            {
                string switchAnswer = GetResponse("Would you like to: \n1) View the list of characters \n2) Add a character to the list \n3) Update a character \n4) Remove a character from the list");

                switch (switchAnswer)
                {
                    case "1":
                        DisplayList(gameCharacters);
                        break;
                    case "2":
                        AddCharacterToList(gameCharacters);
                        break;
                    case "3":
                        UpdateCharacter(gameCharacters);
                        break;
                    case "4":
                        RemoveCharacterFromList(gameCharacters);
                        break;
                    default:
                        Console.WriteLine("That is not a valid selection, try again.");
                        continue;
                }

                Console.WriteLine(" ");
                string endProgram = GetResponse("Would you like to continue to the main menu?  Press Y to continue");
                if (endProgram.ToUpper() != "Y")
                {
                    break;
                }
                Console.Clear();
            }
        }

        public static string GetResponse(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }

        public static string GetStringWithoutNumbers(string message)
        {
            Console.WriteLine(message);
            string answer = Console.ReadLine();

            while (true)
            {
                if (Regex.IsMatch(answer, @"[0-9]"))
                {
                    answer = GetStringWithoutNumbers($"{answer} is not a valid input, please do not enter any numbers or symbols.");
                    continue;
                }
                else
                {
                    return answer;
                }
            }
        }

        public static int GetNumber(string message)
        {
            int number;

            while (true)
            {
                Console.Write(message);
                bool parsed = int.TryParse(Console.ReadLine(), out number);
                if (!parsed || number < 0)
                {
                    Console.WriteLine("That is not valid, please enter a positive number.");
                }
                else
                {
                    return number;
                }
            }
        }

        public static void AddCharacterToList(List<GameCharacter> gameCharacters)
        {
            string answer, name, weapon;
            int strength, intelligence, magicalEnergy, spellNumber;

            while (true)
            {
                answer = GetResponse("Would you like to add a Warrior or Wizard?");
                if (answer.ToLower() == "warrior")
                {
                    name = GetStringWithoutNumbers("What is your warrior's name? ");
                    strength = GetNumber("How much strength do they have? ");
                    intelligence = GetNumber("How intelligent are they? ");
                    weapon = GetStringWithoutNumbers("What kind of weapon do they use? ");
                    GameCharacter userWarrior = new Warrior(name, strength, intelligence, weapon);
                    gameCharacters.Add(userWarrior);
                    break;
                }
                else if (answer.ToLower() == "wizard")
                {
                    name = GetStringWithoutNumbers("What is their name? ");
                    strength = GetNumber("How much strength do they have? ");
                    intelligence = GetNumber("How intelligent are they? ");
                    magicalEnergy = GetNumber("How much magical energy do they have? ");
                    spellNumber = GetNumber("How many spells do they know? ");
                    GameCharacter userWizard = new Wizard(name, strength, intelligence, magicalEnergy, spellNumber);
                    gameCharacters.Add(userWizard);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that's not valid.  Please try again.");
                    continue;
                }
            }  
        }
        
        public static void DisplayList(List<GameCharacter> gameCharacters)
        {
            int count = 1;

            foreach (GameCharacter character in gameCharacters)
            {
                Console.Write($"{count}: ");
                character.Play();
                count++;
            }
        }
        
        public static void UpdateCharacter(List<GameCharacter> gameCharacters)
        {
            int selection;

            DisplayList(gameCharacters);
            selection = GetNumber("Which character would you like to edit?  Please enter a number. ");
            GameCharacter userChoice = gameCharacters[selection - 1];

            if (userChoice.MagicalEnergy == 0 && userChoice.SpellNumber == 0)
            {
                EditWarrior(userChoice);
            }
            else if (userChoice.WeaponType == null)
            {
                EditWizard(userChoice);
            }
            else
            {
                Console.WriteLine("Not sure what happened.");
            }
        }

        public static void EditWarrior(GameCharacter userChoice)
        {
            while (true)
            {
                string answer = GetResponse($"\nYou selected {userChoice.Name}.  What would you like to change for this character? \n" +
                    $"Select from: \n1) Name \n2) Strength \n3) Intelligence \n4) Weapon");

                switch (answer)
                {
                    case "1":
                        string newName = GetResponse($"\nYou want to change {userChoice.Name}'s name.  What would you like their new name to be?");
                        userChoice.Name = newName;
                        Console.WriteLine("The name has been updated.");
                        break;
                    case "2":
                        int newStrength = GetNumber($"\nYou want to change {userChoice.Name}'s strength.  What would you like their new strength level to be?");
                        userChoice.Strength = newStrength;
                        Console.WriteLine($"{userChoice.Name}'s strength has been updated.");
                        break;
                    case "3":
                        int newIntelligence = GetNumber($"\nYou want to change {userChoice.Name}'s intelligence.  What would you like their new intelligence level to be?");
                        userChoice.Intelligence = newIntelligence;
                        Console.WriteLine($"{userChoice.Name}'s intelligence has been updated.");
                        break;
                    case "4":
                        string newWeapon = GetResponse($"\nYou want to change {userChoice.Name}'s weapon.  What would you like their new weapon to be?");
                        userChoice.WeaponType = newWeapon;
                        Console.WriteLine("The weapon has been updated.");
                        break;
                    default:
                        Console.WriteLine("That is not a valid selection, try again.");
                        continue;
                }

                Console.WriteLine(" ");
                string moreChanges = GetResponse("Would you like to keep making edits?  Press Y to continue.");
                if (moreChanges.ToUpper() != "Y")
                {
                    break;
                }
            } 
        }

        public static void EditWizard(GameCharacter userChoice)
        {
            while (true)
            {
                string answer = GetResponse($"\nYou selected {userChoice.Name}.  What would you like to change for this character? \n" +
                    $"Select from: \n1) Name \n2) Strength \n3) Intelligence \n4) Magical Energy \n5) Spell Number");

                switch (answer)
                {
                    case "1":
                        string newName = GetResponse($"\nYou want to change {userChoice.Name}'s name.  What would you like their new name to be?");
                        userChoice.Name = newName;
                        Console.WriteLine("The name has been updated.");
                        break;
                    case "2":
                        int newStrength = GetNumber($"\nYou want to change {userChoice.Name}'s strength.  What would you like their new strength level to be?");
                        userChoice.Strength = newStrength;
                        Console.WriteLine($"{userChoice.Name}'s strength has been updated.");
                        break;
                    case "3":
                        int newIntelligence = GetNumber($"\nYou want to change {userChoice.Name}'s intelligence.  What would you like their new intelligence level to be?");
                        userChoice.Intelligence = newIntelligence;
                        Console.WriteLine($"{userChoice.Name}'s intelligence has been updated.");
                        break;
                    case "4":
                        int newMagicalEnergy = GetNumber($"\nYou want to change {userChoice.Name}'s magical energy.  What would you like their new magical energy level to be?");
                        userChoice.MagicalEnergy = newMagicalEnergy;
                        Console.WriteLine($"{userChoice.Name}'s magical energy has been updated.");
                        break;
                    case "5":
                        int newSpellNumber = GetNumber($"\nYou want to change {userChoice.Name}'s spell number.  How many spells would you like them to know?");
                        userChoice.SpellNumber = newSpellNumber;
                        Console.WriteLine($"{userChoice.Name}'s spell number has been updated.");
                        break;
                    default:
                        Console.WriteLine("That is not a valid selection, try again.");
                        continue;
                }

                Console.WriteLine(" ");
                string moreChanges = GetResponse("Would you like to keep making edits?  Press Y to continue.");
                if (moreChanges.ToUpper() != "Y")
                {
                    break;
                }
            }
        }

        public static void RemoveCharacterFromList(List<GameCharacter> gameCharacters)
        {
            int selection;

            DisplayList(gameCharacters);
            selection = GetNumber("Which character would you like to remove from the list?  Please enter a number. ");
            GameCharacter userChoice = gameCharacters[selection - 1];
            string answer = GetResponse($"\nYou selected {userChoice.Name}.  Are you sure you would like to remove this character from the list? \nChoose Y to remove this character.");
            if (answer.ToUpper() == "Y")
            {
                gameCharacters.Remove(userChoice);
                Console.WriteLine($"{userChoice.Name} has been removed from the list.");
            }
            else
            {
                Console.WriteLine($"{userChoice.Name} will stay on the list for now.");
            }
        }
    }
}
