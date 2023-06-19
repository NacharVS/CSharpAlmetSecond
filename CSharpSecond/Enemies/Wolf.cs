using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecond.Enemies
{
    internal class Wolf : IEnemy
    {
        public int Health 
        { get => 50; 
            set => throw new NotImplementedException(); }
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Attack(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
