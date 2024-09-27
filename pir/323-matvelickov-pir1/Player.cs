using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _323_matvelickov_pir1
{
    class Player
    {
        private readonly string _name;
        private readonly int _age;

        public Player(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name => _name;

        public int Age => _age;
    }
}
