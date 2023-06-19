using CSharpSecond.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecond.EnemyFactories
{
    internal class NormalLvl : IEnemyFactory
    {
        public List<IEnemy> CreateEnemies()
        {
           var enemies = new List<IEnemy>();

            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Wolf());
            }
            for (int i = 0; i < 5; i++)
            {
                enemies.Add(new Bear());
            }
            return enemies;
        }
    }
}
