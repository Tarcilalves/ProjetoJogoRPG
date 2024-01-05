using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    public class Attack : Hero
    {
        
        //Construtor
        public Attack(string name, int level, int hitPoints, int magicPoint, string heroType, string attackType) 
            : base(name, level, hitPoints, magicPoint, heroType, attackType)
        {
        }

         internal string PerformAttack(object enemy, string v)
        {
            throw new NotImplementedException();
        }

       
    }

        

       
}


