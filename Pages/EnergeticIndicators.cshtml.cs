using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace EcoEnergyRazorBBDD.Pages
{
    public class EnergeticIndicatorsModel : PageModel
    {
        // Flags to indicate file existence and records availability
        public bool FileExists { get; set; }
        public bool FileHasRecords { get; set; }

        // Lists to store energy indicators and calculated averages
        public List<EnergyIndicator> EnergyIndicatorList { get; set; } = new List<EnergyIndicator>();
        public void OnGet()
        {
            // Define file path
            const string fileRoute = "wwwroot/Files/indicadors_energetics_cat.csv";
            FileExists = System.IO.File.Exists(fileRoute);

            if (FileExists)
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                };
                using (var reader = new StreamReader(fileRoute))
                using (var csv = new CsvReader(reader, config))
                {
                    // Load CSV records
                    var records = csv.GetRecords<EnergyIndicator>();
                    foreach (var record in records)
                    {
                        EnergyIndicatorList.Add(record);
                    }
                    FileHasRecords = EnergyIndicatorList.Count > 0;
                }
            }
        }
    }
}
