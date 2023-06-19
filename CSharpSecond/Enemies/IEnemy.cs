using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecond.Enemies
{
    internal interface IEnemy
    {
        public int Health { get; set; }
        public int Damage { get; set; }

        public int Attack(int damage);
    }
}
