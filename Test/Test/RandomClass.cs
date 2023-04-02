using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class RandomClass
    {
        private String _name;
        private Int32 _age;

        public event EventHandler? RandomEvent;

        public RandomClass() {
            _name = String.Empty;
            _age = 0;
        }
    }
}
