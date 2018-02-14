using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Fighting
    {
        public static Entitiy player = GameStart.ClassSelection();
        public static Enemy enemy = new Enemy();
        public static bool playerTurn = true;

        public static Fighting FightScence()
        {
            if (player.Health > 0)
            {
                if (enemy.Health > 0)
                {
                    if (playerTurn == true)
                    {
                        Attack.DealDamage(player, enemy);
                        playerTurn = false;
                        Console.WriteLine("The Enemy Has " + enemy.Health + " HP left.");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.ReadLine();
                        return FightScence();
                    }
                    else if (playerTurn == false)
                    {
                        Attack.DealDamage(enemy, player);
                        playerTurn = true;
                        Console.WriteLine("You Have " + player.Health + " HP left.");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.ReadLine();
                        return FightScence();
                    }
                    else
                        return null;
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("NEW CHALLENGER APPROACHES");
                    EnemyRespawn.EnemySpawn(enemy);
                    playerTurn = true;
                    return FightScence(); //WORK ON RESPAWN
                }



            }
            else
            {
                Console.WriteLine("You have died.");
                Console.ReadLine();
                return null;
            }

        }
    }
}
