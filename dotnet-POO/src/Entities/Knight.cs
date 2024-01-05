using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    public class Knight : Hero
    {
        public Attack knightAttack;

        // Construtor
        public Knight(string name, int level, int hitPoints, int magicPoint, string heroType, string attackType) 
            : base(name, level, hitPoints, magicPoint, heroType, attackType)
        {
            knightAttack = new Attack(name, level, hitPoints, magicPoint, heroType, attackType);
        }

        internal string PerformAttack(object enemy, string v)
        {
            throw new NotImplementedException();
        }
    }
}