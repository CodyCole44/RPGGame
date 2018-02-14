using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class TurnChoice
    {
        public static Entitiy player = GameStart.ClassSelection();
        public static Enemy enemy = new Enemy();

        public static void MovePick(int Choice)
        {
            if(Choice == 1)
            {
                Attack.DealDamage(player, enemy);
            }
            else if(Choice == 2)
            {
                Defend.IsDefending(player);
            }
            else
            {
                Console.WriteLine("Please select correct input");
            }
            
        }
    }
}
