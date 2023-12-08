using System;

namespace Roguegame
{
    public class Program
    {
        public static Player currentPlayer = new Player();
        public static bool mainLoop = true;
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
            while (mainLoop)
            {
                Encounters.RandomEncounter();
            }

        }

        static void Start()
        {
            Console.WriteLine("Welcome to my world");
            Console.WriteLine("Write your name to begin: ");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You open your eyes on a dark valley, surrounded by this mysterious fog.");
            if (currentPlayer.name == "")
                Console.WriteLine("You can't remember your own name...");
            else
                Console.WriteLine("The only thing you remember is that your name is " + currentPlayer.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("As you stumble through the thick fog, the screeching grows louder and more intense.");
            Console.WriteLine("It sounds like it's coming from all around you, but you can't quite pinpoint where it's originating from.");
            Console.WriteLine("The only thing you're sure of is that you're not alone in this dark valley.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("As you continue on, the light in the distance becomes more visible, a small flickering flame that seems to be beckoning you forward.");
            Console.WriteLine("You pick up your pace, your heart pounding with every step.");
            Console.WriteLine("Suddenly, a shadowy figure looms out of the fog, its eyes glowing red in the dim light.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You freeze, unsure of what to do.");
            Console.WriteLine("The figure begins to move towards you, its movements jerky and unpredictable.");
            Console.WriteLine("You realize with a start that it's not human, but something far more sinister.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("As the figure gets closer, you see that it's covered in spiky, black fur, with razor-sharp claws and a mouth full of sharp teeth.");
            Console.WriteLine("It lets out a blood-curdling screech, and you know that it's hunting you.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You turn and run, sprinting towards the flickering light in the distance.");
            Console.WriteLine("The creature is hot on your heels, its screeches echoing through the valley.");
            Console.WriteLine("Just when you think it's going to catch you, you burst out of the fog and into a small clearing.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("In the center of the clearing stands an old stone altar, the flickering light coming from a small fire burning atop it.");
            Console.WriteLine("You're not sure why, but you instinctively feel safe here.");
            Console.WriteLine("You turn to face the creature, ready to defend yourself if necessary.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Suddenly, you notice a glint of metal at the foot of the altar.");
            Console.WriteLine("You move closer and see that it's an old sword, its blade dull and rusted.");
            Console.WriteLine("You pick it up, feeling a surge of power as you grip the hilt.");
            Console.WriteLine("With this sword in hand, you feel like you might stand a chance against the creature.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The creature charges towards you, its claws glinting in the firelight.");
            Console.ReadKey();
            Console.Clear();
        }
        /*public static void Print(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
        */
            //Console.ReadKey();
            //Console.WriteLine();
        
       // }



    }
}