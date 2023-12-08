using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame
{
    public class Encounters
    {
        static Random rand = new Random();
        public static void FirstEncounter()
        {
            Console.WriteLine("You take a deep breath and raise the sword, ready to fight.");
            Console.ReadKey();
            Combat(false, "Creature", 2, 10);
        }
        public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine("You continue your journey and stumble upon an enemy, you fight it! ");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }
       /* public static void WizardEncounter() 
        {
            Console.Clear();
            Console.WriteLine("This will be an enemy and a text before fighting it");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }
         */
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 1)) 
            {
                case 0:
                    BasicFightEncounter();
                    break;
            }
        }
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
                n = GetName();
                p = Program.currentPlayer.GetPower();
                h = Program.currentPlayer.GetHealth();
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("╔═╦═══════════════════════════════╗");
                Console.WriteLine("║A║to attack the enemy            ║");
                Console.WriteLine("╠═╬═══════════════════════════════╣");
                Console.WriteLine("║B║to block enemies charge        ║");
                Console.WriteLine("╠═╬═══════════════════════════════╣");
                Console.WriteLine("║H║to use a healing potion        ║");
                Console.WriteLine("╠═╬═══════════════════════════════╣");
                Console.WriteLine("║R║to go run to the village       ║");
                Console.WriteLine("╚═╩═══════════════════════════════╝");
                Console.WriteLine("Potions: " +Program.currentPlayer.potion+" Health:  "+Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //attack
                    Console.WriteLine("You charge forward in fury, striking the "+n+" with your sword!");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1,4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "b" || input.ToLower() == "block")
                {
                    //block
                    Console.WriteLine("You defend yourself with your weapon from the "+n+"'s attack!");
                    int damage = (p/4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                    //Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                   /* if (rand.Next(0, 2) == 0)
                    {
                        //run fail
                        Console.WriteLine("You run away in fear. You realize that the "+n+" is just way too strong for you to handle, but you trip.");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and fail to escape.");
                        Console.ReadKey();
                    }
                   */
                    //else
                    {
                        //run sucsess
                        Console.WriteLine("You run away. You realize that the " + n + " is just way too much for you to handle.");
                        //Console.ReadKey();
                        Shop.LoadShop(Program.currentPlayer);
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    if (Program.currentPlayer.potion == 0)
                    {
                        //heal 
                        Console.WriteLine("You reach into your bag, but you realize you dont have any healing potions left to use!");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Program.currentPlayer.health -= damage;

                        Console.WriteLine("The " + n + " strikes you dealing " + damage + " damage!");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your bag and pull out a blue potion. You take a drink.");
                        int PotionHeal = 5;
                        Console.WriteLine("You gain " +PotionHeal+ " health");
                        Program.currentPlayer.health += PotionHeal;
                        Program.currentPlayer.potion--;
                        //Console.WriteLine("While you were not paying attention to the " + n + ", attacked you");
                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        //Console.WriteLine("You lose " + damage + " health");
                    }
                    Console.ReadKey();
                }
                if (Program.currentPlayer.health <= 0) 
                {
                    Console.WriteLine("You have been slain.");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();

            }
            int c = Program.currentPlayer.GetCoins();
            Console.WriteLine("You just defeated the " + n + ". You get "+c+"coins.");
            Program.currentPlayer.coins += c;

            Console.ReadKey();
            
        }

        public static string GetName()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    return "Ice Wizard";
                case 1:
                    return "Zombie";
                case 2:
                    return "Wolvarine";
                case 3:
                    return "Witch";
            }
            return "Creature";
               

        }

    }
}
