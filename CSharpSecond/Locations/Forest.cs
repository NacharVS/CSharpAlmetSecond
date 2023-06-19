using CSharpSecond.Enemies;
using CSharpSecond.EnemyFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecond.Locations
{
    internal class Forest
    {

        List<IEnemy> enemiesOnMap;

        public Forest(IEnemyFactory factory)
        {
            enemiesOnMap = factory.CreateEnemies();
            GenerateMap();
        }

        public void GenerateMap() // как будто размещаем врагов
        {
            foreach (var item in enemiesOnMap)
            {
                Console.WriteLine();
            }
        }
    }
}
