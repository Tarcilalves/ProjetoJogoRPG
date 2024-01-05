using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    //Forma para criar o objeto
    public abstract class Personagem
    {
        //construtor 
        public Personagem(string name, int level, int hitPoints, int magicPoint, string heroType, string attackType) 
        {
            Name = name;
            Level = level;
            HitPoints = hitPoints;
            MagicPoint = magicPoint;            
            HeroType = heroType;
            AttackType = attackType;

        }

        //construtor vazio
        public Personagem()
        {

        }

        // Atributos ou propriedade
    
        public string Name{ get; set; }
        public int Level { get; set; }
        public int HitPoints { get; set; }
        public int MagicPoint { get; set; }
        public string HeroType { get; set; }
        public string AttackType { get; set; }
        public byte MaxMagicPoint { get; private set; }

        //métodos

        // Método para atualizar os pontos de MP
        protected virtual void UpdateMP(bool successfulAttack)
        {
            if (successfulAttack)
            {
                MagicPoint += 20; // Ganha 20 pontos de MP após um ataque bem-sucedido
                
            }
            else
            {
                MagicPoint += 10; 
            }
            // Garante que MP não ultrapasse o limite
            MagicPoint = Math.Min(MaxMagicPoint, MagicPoint);
        }
        // Método de ataque
        public virtual string PerformAttack(Enemy enemy)
        {
            if (enemy.HitPoints <= 0)
            {
                return $"{Name} inimigo derrotado";
            }
    
            if (MagicPoint >= 20)
            {
                // Minion é derrotado
                enemy.HitPoints = 0;
                UpdateMP(true); // Atualiza os pontos de MP
                return $"{Name} {AttackType}, seu MP {MagicPoint}";
            }
            else
            {
                UpdateMP(false); // Atualiza os pontos de MP
                return $"{Name} {AttackType}, seu MP {MagicPoint}";
            }
        }

    
    }
}