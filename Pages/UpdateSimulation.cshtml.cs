using EcoEnergyRazorBBDD.Data;
using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergyRazorBBDD.Pages
{
    public class UpdateSimulationModel : PageModel
    {
        [BindProperty]
        public EnergySystem Simulation { get; set; }
        public void OnGetSimulation(int id)
        {
            using var context = new ApplicationDbContext();
            Simulation = context.Simulations.Find(id);
        }
        public IActionResult OnPost()
        {
            using var context = new ApplicationDbContext();
            var simulationToUpdate = context.Simulations.Find(Simulation.Id);
            simulationToUpdate.Type = Simulation.Type;
            simulationToUpdate.Ratio = Simulation.Ratio;
            simulationToUpdate.Energy = Simulation.Energy;
            simulationToUpdate.Date = Simulation.Date;
            simulationToUpdate.Price = Simulation.Price;
            simulationToUpdate.Cost = Simulation.Cost;
            simulationToUpdate.TotalCost = Simulation.CalculateTotalCost();
            simulationToUpdate.TotalPrice = Simulation.CalculateTotalPrice();
            context.SaveChanges();
            return RedirectToPage("Simulations");
        }
    }
}
