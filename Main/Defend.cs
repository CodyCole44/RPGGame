using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Defend
    {
        public static void IsDefending(Entitiy Character)
        {
            Character.Defense = Character.Defense * 2;
            Console.WriteLine("Your defense is now " + Character.Defense);
        }
    }
}
