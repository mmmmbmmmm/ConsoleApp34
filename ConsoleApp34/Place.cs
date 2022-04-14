using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place
{
    internal class Place
    {
        public Place(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public Place() { }

        public string Name { get; set; }
        public int Population { get; set; }
        

        public override string ToString()
        {
            return $"Группа - Место\n" +
                $"Название города - {Name}\n" +
                $"Мощность - {Population}\n" +"";
        }
    }
}
