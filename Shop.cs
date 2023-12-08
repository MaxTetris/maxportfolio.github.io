using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame
{
    public class Shop
    {
        static int armorMod;
        static int weaponMod;
        static int difMod;
        public static void LoadShop(Player p)
        {
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int potionP;
            int armorP;
            int weaponP;
            int difP;
            while (true) 
            {
            potionP = 20 + 10 * p.mods;
            armorP = 100 * (p.armorValue+1);
            weaponP = 100 * p.weaponValue;
            difP = 300 + 100 * p.mods;
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════╗");
            Console.WriteLine("║             SHOP                ║");
            Console.WriteLine("╠═╦═══════════════════════════════╣");
            Console.WriteLine("║W║Weapons                        ║ Price: " +weaponP);
            Console.WriteLine("╠═╬═══════════════════════════════╣");
            Console.WriteLine("║P║Potions                        ║ Price: " +potionP);
            Console.WriteLine("╠═╬═══════════════════════════════╣");
            Console.WriteLine("║A║Armor                          ║ Price: " +armorP);
            Console.WriteLine("╠═╬═══════════════════════════════╣");
            Console.WriteLine("║D║Difficulty increase            ║ Price: " + difP);
            Console.WriteLine("╚═╩═══════════════════════════════╝");
                
                Console.WriteLine("╔═════════════════════════════════╗");
                Console.WriteLine("║           Your stats            ║");
                Console.WriteLine("╚═════════════════════════════════╝");
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("▐Your weapons strengh: " + p.weaponValue+ "▐");
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("▐Your potions: " + p.potion + "▐");
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("▐Your health: " + p.health+ "▐");
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("▐Your armor: " + p.armorValue+ "▐");
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("▐Difficulty: " + p.mods+ "▐");
                Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("Your coins:  " + p.coins);
                Console.WriteLine("E to leave the shop and continue your journey");


                string input = Console.ReadLine().ToLower();
                if (input == "w" || input == "weapons")
                {
                    TryBuy("weapon", weaponP, p);
                }
                else if (input == "p" || input == "potion")
                {
                    TryBuy("potion", potionP, p);
                }
                else if (input == "a" || input == "armor")
                {
                    TryBuy("armor", armorP, p);
                }
                else if (input == "d" || input == "difficulty mod")
                {
                    TryBuy("dif", difP, p);
                }
                else if (input == "e" || input == "exit")

                    break;
                
                
            }
           
        }
        static void TryBuy(string item, int cost, Player p)
        {
            if(p.coins>=cost)
            {
                if (item == "potion")
                    p.potion++;
                else if (item == "weapon")
                    p.weaponValue++;
                else if (item == "armor")
                    p.armorValue++;
                else if (item == "dif")
                    p.mods++;
                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("You dont have enough coins!");
                Console.ReadKey();
            }
        }
    }
}
