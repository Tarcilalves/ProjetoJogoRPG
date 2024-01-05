using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    public class Minions : Enemy
    {
        // Construtor
        public Minions(string name, int level, int hitPoints, int magicPoint, string enemyType, string attackType) 
            : base(name, level, hitPoints, magicPoint, enemyType, attackType)
        {
            AttackType = attackType;
        }

        
    }
}
