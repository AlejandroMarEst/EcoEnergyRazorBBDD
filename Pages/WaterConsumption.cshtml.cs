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
    }
}
