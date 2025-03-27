using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergyRazorBBDD.Data;
using EcoEnergyRazorBBDD.DTOs;
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
        public bool FileHasRecords { get; set; } = true;

        // Handles GET request to load water consumption data
        public void OnGet()
        {
            using var context = new ApplicationDbContext();
            WaterConsumptionList = context.WaterConsumption.ToList();
            FileHasRecords = WaterConsumptionList.Count > 0;
        }
        public IActionResult OnPostDeleteRecord(int id)
        {
            using var context = new ApplicationDbContext();
            WaterConsumptionLog simDelete = context.WaterConsumption.Find(id)!;
            Console.WriteLine(simDelete);
            context.WaterConsumption.Remove(simDelete);
            context.SaveChanges();
            return RedirectToPage("WaterConsumption");
        }
        public IActionResult OnPostUpdateRecord(int id)
        {
            return RedirectToPage("UpdateWaterConsumption", "Consumption", new { Id = id });
        }
        public IActionResult OnPostSeed()
        {
            using var context = new ApplicationDbContext();
            var reader = new StreamReader("wwwroot/Files/consum_aigua_cat_per_comarques.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<WaterConsumptionLogDTO>().ToList();
            foreach (var record in records)
            {
                WaterConsumptionLog newRecord = new WaterConsumptionLog
                {
                    Year = record.Year,
                    RegionID = record.RegionID,
                    RegionName = record.RegionName,
                    Population = record.Population,
                    DomesticNET = record.DomesticNET,
                    EconomicActivities = record.EconomicActivities,
                    Total = record.Total,
                    DomesticConsumption = record.DomesticConsumption
                };
                context.WaterConsumption.Add(newRecord);
                context.SaveChanges();
            }
            return RedirectToPage("WaterConsumption");
        }
        public IActionResult OnPostDeleteAll()
        {
            using var context = new ApplicationDbContext();
            context.WaterConsumption.RemoveRange(context.WaterConsumption);
            context.SaveChanges();
            return RedirectToPage("WaterConsumption");
        }
    }
}
