using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsSystem
{
    public class Cat
    {
        public Cat(CatColor color)
        {
            this.Color = color;
        }

        public string Name { get; set; }

        public CatColor Color { get; private set; }

        public int Age { get; private set; }

        public Owner Owner { get; set; }
    }
}
