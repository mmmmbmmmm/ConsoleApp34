using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place
{
    internal class Megapolis:Place
    {
        public Megapolis(string name, int capacity,  int population_density) : base(name, capacity)
        {
            Population_density = population_density;
        }

        public Megapolis() { }

        public int Population_density { get; set; }

        public override string ToString()
        {
            return $"Группа - Мегаполис\n" +
                $"Название города - {Name}\n" +
                $"Население - {Population}\n" +
            $"Плотность населения - {Population_density} литров\n";
        }
    }
}
