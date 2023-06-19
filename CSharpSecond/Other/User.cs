using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSecond.Other
{
    internal class User
    {
        public User(string name, int age)
        {
            _name = name;
            Age = age;
            registrationDate = DateTime.Now;
        }

        private string _name;
        public string Name { get => _name; }
        public int Age { get; set; }
        public DateTime registrationDate { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Age} {registrationDate}");
        }

        public string ChangeName(string newName)
        {
            _name = newName;
            return Name;
        }
    }
}
