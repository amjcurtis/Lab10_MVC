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
		// Properties of Wine class (taken from CSV header row)
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
		
		/// <summary>
		///  Reads CSV file, instantiates Wine objects, and returns list of wines that match user search parameters
		/// </summary>
		/// <param name="targetPrice">user's desired max price</param>
		/// <param name="wineRating">user's desired minimum wine rating</param>
		/// <returns>list of Wine objects matching user search parameters</returns>
        public static List<Wine> GetWineList(int targetPrice, int wineRating)
        {
			// Code to always look at your `wwwroot` folder
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/wine.csv");
			
			// Instantiate new wine list
			List<Wine> wineList = new List<Wine>();

			// Read CSV and get specified number of lines
			var selectedLines = File.ReadAllLines(path)
							.Skip(1)
							.Take(15);

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

			// Query wine list and filter based on user search input
			var filteredWines = wineList
								.Where(wine => wine.Points >= wineRating)
								.Where(wine => wine.Price <= targetPrice)
								.OrderByDescending(wine => wine.Points);

			// Instantiate new list of wines reflecting filtered results
			List<Wine> wineSearchResultsList = new List<Wine>();

			// Populate new wine list with wines that meet parameters of user's search
			foreach (var wine in filteredWines)
			{
				wineSearchResultsList.Add(wine);
			}

			// Return list of wines
			return wineSearchResultsList;
        }
    }
}
