using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergyRazorBBDD.Data;
using EcoEnergyRazorBBDD.DTOs;
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
            return RedirectToPage("EnergeticIndicators");
        }
        public IActionResult OnPostUpdateRecord(int id)
        {
            return RedirectToPage("UpdateEnergyIndicators", "Indicator", new { Id = id });
        }
        public IActionResult OnPostSeed()
        {
            using var context = new ApplicationDbContext();
            var reader = new StreamReader("wwwroot/Files/indicadors_energetics_cat.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<EnergyIndicatorDTO>().ToList();
            foreach (var r in records)
            {
                EnergyIndicator indicador = new EnergyIndicator
                {
                    Date = r.Date,
                    PBEE_Hydroelectric = r.PBEE_Hydroelectric,
                    PBEE_Coal = r.PBEE_Coal,
                    PBEE_NaturalGas = r.PBEE_NaturalGas,
                    PBEE_FuelOil = r.PBEE_FuelOil,
                    PBEE_CombinedCycle = r.PBEE_CombinedCycle,
                    PBEE_Nuclear = r.PBEE_Nuclear,
                    CDEEBC_GrossProduction = r.CDEEBC_GrossProduction,
                    CDEEBC_AuxConsumption = r.CDEEBC_AuxConsumption,
                    CDEEBC_NetProduction = r.CDEEBC_NetProduction,
                    CDEEBC_PumpConsumption = r.CDEEBC_PumpConsumption,
                    CDEEBC_AvailableProduction = r.CDEEBC_AvailableProduction,
                    CDEEBC_TotalNetworkSalesCentral = r.CDEEBC_TotalNetworkSalesCentral,
                    CDEEBC_ElectricExchangeBalance = r.CDEEBC_ElectricExchangeBalance,
                    CDEEBC_ElectricDemand = r.CDEEBC_ElectricDemand,
                    CDEEBC_TotalRegulatedMarket = r.CDEEBC_TotalRegulatedMarket,
                    CDEEBC_TotalFreeMarket = r.CDEEBC_TotalFreeMarket,
                    FEE_Industry = r.FEE_Industry,
                    FEE_Tertiary = r.FEE_Tertiary,
                    FEE_Domestic = r.FEE_Domestic,
                    FEE_Primary = r.FEE_Primary,
                    FEE_Energetic = r.FEE_Energetic,
                    FEEI_PublicWorksConsumption = r.FEEI_PublicWorksConsumption,
                    FEEI_IronSteelFoundry = r.FEEI_IronSteelFoundry,
                    FEEI_Metallurgy = r.FEEI_Metallurgy,
                    FEEI_GlassIndustry = r.FEEI_GlassIndustry,
                    FEEI_CementLimeGypsum = r.FEEI_CementLimeGypsum,
                    FEEI_OtherConstructionMaterials = r.FEEI_OtherConstructionMaterials,
                    FEEI_ChemicalPetrochemical = r.FEEI_ChemicalPetrochemical,
                    FEEI_TransportMediumConstruction = r.FEEI_TransportMediumConstruction,
                    FEEI_OtherMetalTransformation = r.FEEI_OtherMetalTransformation,
                    FEEI_FoodBeverageTobacco = r.FEEI_FoodBeverageTobacco,
                    FEEI_TextileClothingLeatherFootwear = r.FEEI_TextileClothingLeatherFootwear,
                    FEEI_PulpPaperCardboard = r.FEEI_PulpPaperCardboard,
                    FEEI_OtherIndustries = r.FEEI_OtherIndustries,
                    DGGN_FrontierPointEnagas = r.DGGN_FrontierPointEnagas,
                    DGGN_LNGDistributionSupply = r.DGGN_LNGDistributionSupply,
                    DGGN_ThermalPowerPlantGNCConsumption = r.DGGN_ThermalPowerPlantGNCConsumption,
                    CCAC_AutoGasoline = r.CCAC_AutoGasoline,
                    CCAC_AutoDieselA = r.CCAC_AutoDieselA
                };
                context.EnergyIndicator.Add(indicador);
                context.SaveChanges();
            }
            return RedirectToPage("EnergeticIndicators");
        }
        public IActionResult OnPostDeleteAll()
        {
            using var context = new ApplicationDbContext();
            context.EnergyIndicator.RemoveRange(context.EnergyIndicator);
            context.SaveChanges();
            return RedirectToPage("EnergeticIndicators");
        }
    }
}
