using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country
{

    public class Country
    {
        public string name { get; private set; }
        public City capital { get;  private  set; }
        public string presidentName { get;  set; }
        public List<City> cities = new List<City>();

        public int cityCount
        {
            get
            {
                return cities.Count;
            }
        }
        public long totalPopulation 
        {
            get
            {
                long total = 0;
                foreach (var city in cities)
                {
                    total += city.Population;
                }
                return total;
            }
        }

        public int alaySayisi;

        public int totalaskerSayisi
        {
            get
            {
                return alaySayisi * 1000;
            }
        }

        public Country(string name, string presidentname)
        {
            this.name = name;
           presidentName = presidentname;
        }

        public void addCity(City city)
        {
            cities.Add(city);
            city.Owner = this;
        }

        public void removeCity(City city)
        {
            if (capital == city)
            {
                capital = null; 
            }
            cities.Remove(city);
            city.Owner = null;
        }

        public void setCapital(City capitalCity)
        {
            if (capitalCity.Owner == this)
            {
                capital = capitalCity;
            }
           
        }
    }
    public class City
    {
        public string name { get; private set; }
        public long Population { get;  set; }
        public Country Owner { get; internal set; }

        public bool isCapital
        {
            get
            {
                if (Owner != null && Owner.capital == this)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public City(string name, int population)
        {
            this.name = name;
            Population = population;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            City istanbul = new City("İstanbul", 15000000);
            City adana = new City("Adana", 2200000);
            City ankara = new City("Ankara", 5500000);
            Country turkiye = new Country("Türkiye", "Recep Tayyip Erdoğan");

            turkiye.addCity(istanbul);
            turkiye.addCity(adana);
            turkiye.addCity(ankara);

            turkiye.setCapital(ankara);

            Console.WriteLine(turkiye.totalPopulation);
             Console.WriteLine(turkiye.cityCount);
            Console.WriteLine(adana.Owner.name);
            turkiye.alaySayisi = 5;
            Console.WriteLine(turkiye.totalaskerSayisi);
            Console.WriteLine(turkiye.capital.name);

        }
    }
}
