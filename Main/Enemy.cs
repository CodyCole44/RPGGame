using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Enemy : Entitiy
    {
        public Enemy()
        {
            Random rnd = new Random();
            Health = rnd.Next(1, 21);
            Attack = rnd.Next(4, 9);
            Defense = rnd.Next(0, 4);

            Console.WriteLine("Enemy Attack: " + Attack);
            Console.WriteLine("Enemy Health: " + Health);
            Console.WriteLine("Enemy Defense: " + Defense);
            Console.ReadLine();
        }

    }
}
