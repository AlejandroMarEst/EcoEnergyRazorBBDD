using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergyRazorBBDD.Data;
using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Net;

namespace EcoEnergyRazorBBDD.Pages
{
    public class EnergeticIndicatorsModel : PageModel
    {
        // Flags to indicate  records availability
        public bool FileHasRecords { get; set; }

        // Lists to store energy indicators and calculated averages
        public List<EnergyIndicator> EnergyIndicatorList { get; set; } = new List<EnergyIndicator>();
        public void OnGet()
        {
            using var context = new ApplicationDbContext();
            EnergyIndicatorList = context.EnergyIndicator.ToList();
            FileHasRecords = EnergyIndicatorList.Count > 0;
        }
        public IActionResult OnPostDeleteRecord(int id)
        {
            using var context = new ApplicationDbContext();
            EnergyIndicator simDelete = context.EnergyIndicator.Find(id)!;
            Console.WriteLine(simDelete);
            context.EnergyIndicator.Remove(simDelete);
            context.SaveChanges();
            return RedirectToPage("EnergyIndicators");
        }
        public IActionResult OnPostUpdateRecord(int id)
        {
            return RedirectToPage("UpdateEnergyIndicators", "Indicator", new { Id = id });
        }
    }
}
