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
		public string Province { get; set; }
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
			var selectedLines = File.ReadAllLines(path)
							.Skip(1)
							.Take(100);

			var filteredLines = selectedLines
								.Where(wine => wine.Price <= targetPrice);
			
			// Iterate over selected lines and generate Wine object from each line in CSV
			foreach (string line in selectedLines)
			{
				// Divide current line/row into columns and put into string array
				string[] rowColumn = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

				// Instantiate new wine object with contents of array of columns from each row
				Wine wine = new Wine
				{
					ID = int.Parse(rowColumn[0]),
					Country = rowColumn[1],
					Description = rowColumn[2],
					Designation = rowColumn[3],
					Points = int.Parse(rowColumn[4]),
					Price = decimal.Parse(rowColumn[5]),
					Province = rowColumn[6],
					Region_1 = rowColumn[7],
					Region_2 = rowColumn[8],
					Variety = rowColumn[9],
					Winery = rowColumn[10]
				};

				// Add new Wine object to wine list to be returned from method
				wineList.Add(wine);
			}

			// Return list of wines
			return wineList;
        }
    }
}
