using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    public class Ninja : Personagem
    {
         public Attack ninjaAttack;

        // Construtor
        public Ninja(string name, int level, int hitPoints, int magicPoint, string heroType, string attackType)
            : base(name, level, hitPoints, magicPoint, heroType, attackType)
        {
            ninjaAttack = new Attack(name, level, hitPoints, magicPoint, heroType, attackType);
        }

        internal string PerformAttack(string v)
        {
            throw new NotImplementedException();
        }
    }
}