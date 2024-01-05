using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    public abstract class Enemy : Hero
    {
        // Construtor
        public Enemy(string name, int level, int hitPoints, int magicPoint, string enemyType, string attackType) 
        {
            Name = name;
            Level = level;
            HitPoints = hitPoints;
            MagicPoint = magicPoint;            
            EnemyType = enemyType;
            AttackType = attackType;   
        }

        // Construtor vazio
        public Enemy()
        {
            // Pode inicializar valores padrão, se necessário
        }

        // Propriedades
        
        public string EnemyType { get; set; }
        

        // Método de contra-ataque virtual
        public virtual string CounterAttack()
        {
            return $"{EnemyType} Contratacou";
        }
    }
}