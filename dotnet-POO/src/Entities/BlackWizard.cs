using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    public class BlackWizard : Personagem
    {
        // classe contrutora
        public Attack blackWizardAttack;
        public BlackWizard(string name, int level, int hitPoints, int magicPoint, string heroType, string attackType)
            : base(name, level, hitPoints, magicPoint, heroType, attackType)
        {
           blackWizardAttack = new Attack(name, level, hitPoints, magicPoint, heroType, attackType); 
        }
        internal string PerformAttack(object enemy, string v)
        {
            throw new NotImplementedException();
        }

       
    }
        
}
