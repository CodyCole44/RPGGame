using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class EnemyRespawn
    {
        public static Enemy EnemySpawn(Enemy enemy)
        {
            Random rnd = new Random();
            enemy.Health = rnd.Next(1, 21);
            enemy.Attack = rnd.Next(4, 9);
            enemy.Defense = rnd.Next(0, 4);

            Console.WriteLine("Enemy Attack: " + enemy.Attack);
            Console.WriteLine("Enemy Health: " + enemy.Health);
            Console.WriteLine("Enemy Defense: " + enemy.Defense);

            return enemy;

        }
    }
}
