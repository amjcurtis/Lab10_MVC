using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
			// Code to always look at your `wwwroot` folder
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/wine.csv");
			
			// Instantiate new wine list
			List<Wine> wineList = new List<Wine>();

			// Read CSV
            var data = new StreamReader(File.OpenRead(path));

			// Put read CSV data into array or similar
			// Skip header

			// Inside loop to specify certain number of lines
			for (int i = 1; i < data.Length; i++)
			{
				string currentString = data.ReadLine();
				string[] csvData = Regex.Split(currentString, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

			}

			//TODO Linq query to filter CSV results
			var wineResults = from
							  where /* points are >= desired point rating */
							  where /* price <= desired target price */

			// Return List<Wine>
			return wineList;
        }

    }
}
