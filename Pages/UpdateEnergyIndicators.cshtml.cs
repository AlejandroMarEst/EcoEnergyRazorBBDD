using EcoEnergyRazorBBDD.Data;
using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergyRazorBBDD.Pages
{
    public class UpdateEnergyIndicatorsModel : PageModel
    {
        [BindProperty]
        public EnergyIndicator EnergyIndicator { get; set; }
        public void OnGetIndicator(int id)
        {
            using var context = new ApplicationDbContext();
            EnergyIndicator = context.EnergyIndicator.Find(id);
        }
        public IActionResult OnPost()
        {
            using var context = new ApplicationDbContext();
            EnergyIndicator indicatorToUpdate = context.EnergyIndicator.Find(EnergyIndicator.Id);
            indicatorToUpdate.Date = EnergyIndicator.Date;
            indicatorToUpdate.CDEEBC_NetProduction = EnergyIndicator.CDEEBC_NetProduction;
            indicatorToUpdate.CCAC_AutoGasoline = EnergyIndicator.CCAC_AutoGasoline;
            indicatorToUpdate.CDEEBC_ElectricDemand = EnergyIndicator.CDEEBC_ElectricDemand;
            indicatorToUpdate.CDEEBC_AvailableProduction = EnergyIndicator.CDEEBC_AvailableProduction;
            context.SaveChanges();
            return RedirectToPage("EnergeticIndicators");
        }
    }
}
