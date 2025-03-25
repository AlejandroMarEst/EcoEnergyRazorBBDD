using EcoEnergyRazorBBDD.Data;
using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace EcoEnergyRazorBBDD.Pages
{
    public class AddWaterConsumptionModel : PageModel
    {
        [BindProperty]
        public WaterConsumptionLog? UserWaterConsumption { get; set; }

        public IActionResult OnPost()
        {
            using var context = new ApplicationDbContext();
            context.WaterConsumption.Add(UserWaterConsumption);
            context.SaveChanges();
            return RedirectToPage("WaterConsumption");
        }
    }
}
