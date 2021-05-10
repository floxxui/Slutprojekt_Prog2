using System;

namespace Prog2
{
    public class RNGHero: AttackHero
    {
        private Random generator = new Random();
        //Random gör att man kan få ut ett random nummer, vilket i detta projekt används för att randomizea när hero'n kommer göra extra mycket damage och dubbelt så lite damage
        public RNGHero()
        {
            
        }
        //Ingen kod har lagts in i projektet ennu
        //Random ska randoma ut en siffra mellan 1 och 2
        //Om resultatet blir 1 gör den hälften så mycket damage som Hero
        //Om resultatet blir 2 gör den dubbelt så mycket damage som Hero
    }
}
