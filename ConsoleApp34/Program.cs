using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Place
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Place place = new Place("Место", 60000);
            Area area = new Area("Волгоградская область", 900000, 113900);
            Сity city = new Сity("Волгоград", 476, 86);
         Megapolis megapolis = new Megapolis("Москва", 11514330, 4955);


            Console.WriteLine(place.ToString());
            Console.WriteLine(area.ToString());
            Console.WriteLine(city.ToString());
            Console.WriteLine(megapolis.ToString());

            Console.ReadKey();
        }
    }
}
