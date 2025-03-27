using EcoEnergyRazorBBDD.Data;
using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergyRazorBBDD.Pages
{
    public class UpdateWaterConsumptionModel : PageModel
    {
        [BindProperty]
        public WaterConsumptionLog WaterConsumption { get; set; }
        public void OnGetConsumption(int id)
        {
            using var context = new ApplicationDbContext();
            WaterConsumption = context.WaterConsumption.Find(id);
        }
        public IActionResult OnPost()
        {
            using var context = new ApplicationDbContext();
            WaterConsumptionLog consumptionToUpdate = context.WaterConsumption.Find(WaterConsumption.Id);
            consumptionToUpdate.Year = WaterConsumption.Year;
            consumptionToUpdate.RegionID = WaterConsumption.RegionID;
            consumptionToUpdate.RegionName = WaterConsumption.RegionName;
            consumptionToUpdate.Population = WaterConsumption.Population;
            consumptionToUpdate.DomesticNET = WaterConsumption.DomesticNET;
            consumptionToUpdate.EconomicActivities = WaterConsumption.EconomicActivities;
            consumptionToUpdate.Total = WaterConsumption.Total;
            consumptionToUpdate.DomesticConsumption = WaterConsumption.DomesticConsumption;
            context.SaveChanges();
            return RedirectToPage("WaterConsumption");
        }
    }
}
