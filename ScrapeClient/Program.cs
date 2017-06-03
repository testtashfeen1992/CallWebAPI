using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScarpe = new Scrape();

            string value = myScarpe.ScrapeWebpage("https://graph.facebook.com/youtube?access_token=EAACW5Fg5N2IBADv8LvWFIqMyj51WODAKdQhnH7B83ZBZB9RwxBrN79TJZAcI2YuBYzE9psjn7btYceQFCu5nTmAkRNqFXDPi63LzjziYx86DEoZBVNnFIhGdw1rWc0YrEW2Hqj4ajdT9uOAifTIkiM4GAPWSZA7OJJqTsLbXYduZCCupH6Fot6");

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
