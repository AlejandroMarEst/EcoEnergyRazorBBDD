using EcoEnergyRazorBBDD.Data;
using EcoEnergyRazorBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace EcoEnergyRazorBBDD.Pages
{
    // PageModel for inserting a new energy indicator
    public class InsertEnergyIndicatorModel : PageModel
    {
        [BindProperty]
        public EnergyIndicator? EnergyIndicator { get; set; }
        public IActionResult OnPost()
        {
            const double defaultValue = 0;

            // Create a new EnergyIndicator object with specified and default values
            EnergyIndicator indicator = new EnergyIndicator
            {
                Date = EnergyIndicator!.Date,
                PBEE_Hydroelectric = defaultValue,
                PBEE_Coal = defaultValue,
                PBEE_NaturalGas = defaultValue,
                PBEE_FuelOil = defaultValue,
                PBEE_CombinedCycle = defaultValue,
                PBEE_Nuclear = defaultValue,
                CDEEBC_GrossProduction = defaultValue,
                CDEEBC_AuxConsumption = defaultValue,
                CDEEBC_NetProduction = EnergyIndicator.CDEEBC_NetProduction,
                CDEEBC_PumpConsumption = defaultValue,
                CDEEBC_AvailableProduction = EnergyIndicator.CDEEBC_AvailableProduction,
                CDEEBC_TotalNetworkSalesCentral = defaultValue,
                CDEEBC_ElectricExchangeBalance = defaultValue,
                CDEEBC_ElectricDemand = EnergyIndicator.CDEEBC_ElectricDemand,
                CDEEBC_TotalRegulatedMarket = defaultValue,
                CDEEBC_TotalFreeMarket = defaultValue,
                FEE_Industry = defaultValue,
                FEE_Tertiary = defaultValue,
                FEE_Domestic = defaultValue,
                FEE_Primary = defaultValue,
                FEE_Energetic = defaultValue,
                FEEI_PublicWorksConsumption = defaultValue,
                FEEI_IronSteelFoundry = defaultValue,
                FEEI_Metallurgy = defaultValue,
                FEEI_GlassIndustry = defaultValue,
                FEEI_CementLimeGypsum = defaultValue,
                FEEI_OtherConstructionMaterials = defaultValue,
                FEEI_ChemicalPetrochemical = defaultValue,
                FEEI_TransportMediumConstruction = defaultValue,
                FEEI_OtherMetalTransformation = defaultValue,
                FEEI_FoodBeverageTobacco = defaultValue,
                FEEI_TextileClothingLeatherFootwear = defaultValue,
                FEEI_PulpPaperCardboard = defaultValue,
                FEEI_OtherIndustries = defaultValue,
                DGGN_FrontierPointEnagas = defaultValue,
                DGGN_LNGDistributionSupply = defaultValue,
                DGGN_ThermalPowerPlantGNCConsumption = defaultValue,
                CCAC_AutoGasoline = EnergyIndicator.CCAC_AutoGasoline,
                CCAC_AutoDieselA = defaultValue
            };
            using var context = new ApplicationDbContext();
            context.EnergyIndicator.Add(indicator);
            context.SaveChanges();
            return RedirectToPage("EnergeticIndicators");
        }
    }
}
