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
			
			// Read CSV
            //var data = new StreamReader(File.OpenRead(path));

			// Put read CSV data into array or similar
			// Skip header
			//string[] dataAsArray = /* readalllines */;

			// Instantiate new wine list
			List<Wine> wineList = new List<Wine>();

			var selectedLines = File.ReadAllLines(path)
							.Skip(1)
							.Take(100);

			var filteredLines = selectedLines
								.Where(wine => wine.Price <= targetPrice);

			foreach (string line in selectedLines)
			{
				string[] rowColumn = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

				Wine wine = new Wine
				{
					ID = int.Parse(rowColumn[0]),
					Country = rowColumn[1],
					Description = rowColumn[2],
					Designation = rowColumn[3],
					Points = int.Parse(rowColumn[4]),
					Price = decimal.Parse(rowColumn[5]),
					Region_1 = rowColumn[6],
					Region_2 = rowColumn[7],
					Variety = rowColumn[8],
					Winery = rowColumn[9]
				};

				wineList.Add(wine);
			}

			//// Inside loop to specify certain number of lines
			//for (int i = 1; i < dataAsArray.Length; i++)
			//{
			//	string line = data.ReadLine();

			//}

			//TODO Linq query to filter CSV results
			var wineResults = from
							  where /* points are >= desired point rating */
							  where /* price <= desired target price */

			// Return List<Wine>
			return wineList;
        }

    }
}
