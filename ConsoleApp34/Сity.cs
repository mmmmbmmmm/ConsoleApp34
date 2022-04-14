using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place
{
    internal class Сity:Place
    {
        public Сity(string name, int capacity,  int economy) : base(name, capacity)
        {
            Economy = economy;
        }

        public Сity() { }

        public int Economy { get; set; }

        public override string ToString()
        {
            return $"Группа - Город\n" +
                $"Название города - {Name}\n" +
                $"Население - {Population}\n" +
                $"Экономика  - {Economy} C\n";
        }
    }
}
