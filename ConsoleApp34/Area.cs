using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place
{
    internal class Area:Place
    {
        public Area(string name, int capacity,  int squarer) : base(name, capacity)
        {
            Squarer = squarer;
        }

        public Area() { }

        public int Squarer { get; set; }

        public override string ToString()
        {
            return $"Группа - Область\n" +
                $"Название города- {Name}\n" +
                $"Население - {Population}\n" +
                $"Площадь - {Squarer} г.\n";
        }
    }
}
