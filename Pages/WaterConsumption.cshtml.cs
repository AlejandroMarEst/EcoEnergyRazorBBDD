using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace EcoEnergyRazorBBDD.Pages
{
    // PageModel for displaying water consumption data
    public class WaterConsumptionModel : PageModel
    {
        public List<WaterConsumptionLog> WaterConsumptionList { get; set; } = new List<WaterConsumptionLog>();
        public bool Exists { get; set; } = true;
        public bool HasContent { get; set; } = true;

        // Handles GET request to load water consumption data
        public void OnGet()
        {
            const string filePath = "wwwroot/Files/consum_aigua_cat_per_comarques.csv";

            // Check if the file exists
            if (System.IO.File.Exists(filePath))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                };
                using var reader = new StreamReader(filePath);
                using (var csv = new CsvReader(reader, config))
                {
                    // Read water consumption records from CSV file
                    var records = csv.GetRecords<WaterConsumptionLog>();
                    foreach (var line in records)
                    {
                        WaterConsumptionList.Add(line);
                    }
                    // Check if the file has any content
                    HasContent = WaterConsumptionList.Count == 0;
                }
            }
            else
            {
                Exists = false;
            }
        }
    }
}
