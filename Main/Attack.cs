using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Attack
    {

        public static void DealDamage(Entitiy Attacker, Entitiy Defender)
        {

            int NeedToHit = 8;
            Random randomHit = new Random();
            int HitNumber;
            HitNumber = randomHit.Next(1, 10);
            bool itHit = false;
            int Damage = Attacker.Attack - Defender.Defense;

            if (HitNumber > NeedToHit)
            {
                itHit = false;
            }
            else
            {
                itHit = true;
            }

            if (itHit == true)
            {
                if (Attacker.Attack > Defender.Defense)

                {
                    Defender.Health = Defender.Health - Damage;
                    Console.WriteLine("The attack did " + Damage + " damage.");
                }
                else
                {
                    Console.WriteLine("Defense was too Great. No damage taken.");
                }
            }
            else if (itHit == false)
            {
                Console.WriteLine("The Attack Missed.");
            }
        }




    }
}
