using CSharpSecond.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecond.EnemyFactories
{
    internal interface IEnemyFactory
    {
        public List<IEnemy> CreateEnemies();
    }
}
