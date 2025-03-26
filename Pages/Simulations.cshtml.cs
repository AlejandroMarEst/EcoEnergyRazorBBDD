using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using EcoEnergyRazorBBDD.Data;

namespace EcoEnergyRazorBBDD.Pages
{
    // PageModel for displaying saved energy simulations
    public class SimulationsModel : PageModel
    {
        public List<EnergySystem> Simulations { get; set; } = new List<EnergySystem>();
        public bool FileHasRecords { get; set; }

        public void OnGet()
        {
            using var context = new ApplicationDbContext();
            Simulations = context.Simulations.ToList();
            FileHasRecords = Simulations.Count > 0;
        }
        public IActionResult OnPostDeleteRecord(int id)
        {
            using var context = new ApplicationDbContext();
            EnergySystem simDelete = context.Simulations.Find(id)!;
            Console.WriteLine(simDelete);
            context.Simulations.Remove(simDelete);
            context.SaveChanges();
            return RedirectToPage("Simulations");
        }
    }
}
