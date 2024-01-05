using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    public class WhiteWizard : Personagem
    {
         public Attack whiteWizardAttack;

        // Construtor
        public WhiteWizard(string name, int level, int hitPoints, int magicPoint, string heroType, string attackType)
            : base(name, level, hitPoints, magicPoint, heroType, attackType)
        {
            whiteWizardAttack = new Attack(name, level, hitPoints, magicPoint, heroType, attackType);
        }

          public override string ToString()
        {
                        
            return $" O hero {Name} do tipo {HeroType} lançou um {AttackType}, seu MP {MagicPoint} ";

        }

        internal string PerformAttack(string v)
        {
            throw new NotImplementedException();
        }
    }
}