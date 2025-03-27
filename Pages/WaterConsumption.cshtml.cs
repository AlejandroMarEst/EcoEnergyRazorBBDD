using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergyRazorBBDD.Data;
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
    }
}
