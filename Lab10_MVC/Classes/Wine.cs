using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10_MVC.Classes
{
    public class Wine
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Designation { get; set; }
        public int Points { get; set; }
        public decimal Price { get; set; }
        public string Region_1 { get; set; }
        public string Region_2 { get; set; }
        public string Variety { get; set; }
        public string Winery { get; set; }


        public static List<Wine> GetWineList(int targetPrice, int wineRating)
        {
            //string path = "../Models/wine.csv";
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/wine.csv");

			List<Wine> wineList = new List<Wine>();

            var data = "";
            using (StreamReader sr = File.OpenText(path))
            {
                data = sr.ReadToEnd();
            }

			//TODO For each line in converted CSV data, convert it into Wine object using object initializer and add it to Line<Wine>

			//TODO Wine constructor (in for loop)


			//TODO Return List<Wine>
			return wineList;
        }

    }
}
