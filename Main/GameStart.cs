using System;
using System.Collections.Generic;
using System.Text;
using Main;

namespace Main
{
    public class GameStart
    {
        public static void GoGame()
        {
            var sb = new StringBuilder();
            sb.Append("Welcome To Your Worst NightMare");
            sb.AppendLine("Muhahahaha");
            sb.AppendLine("Please choose a class");
            Console.WriteLine(sb);            
            
        }
        public static Entitiy ClassSelection()
        {
            Console.WriteLine("Press: 1 for Warrior");
            int choice;

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                var player = new Warrior();
                return player;
            }
            else
            {
                Console.WriteLine("Incorrect input. Try again.");
                return ClassSelection();
                
            }
        }
        
    }
}
