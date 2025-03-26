using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEnergyRazorBBDD.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnergyIndicator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PBEE_Hydroelectric = table.Column<double>(type: "float", nullable: false),
                    PBEE_Coal = table.Column<double>(type: "float", nullable: false),
                    PBEE_NaturalGas = table.Column<double>(type: "float", nullable: false),
                    PBEE_FuelOil = table.Column<double>(type: "float", nullable: false),
                    PBEE_CombinedCycle = table.Column<double>(type: "float", nullable: false),
                    PBEE_Nuclear = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_GrossProduction = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_AuxConsumption = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_NetProduction = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_PumpConsumption = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_AvailableProduction = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_TotalNetworkSalesCentral = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_ElectricExchangeBalance = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_ElectricDemand = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_TotalRegulatedMarket = table.Column<double>(type: "float", nullable: false),
                    CDEEBC_TotalFreeMarket = table.Column<double>(type: "float", nullable: false),
                    FEE_Industry = table.Column<double>(type: "float", nullable: true),
                    FEE_Tertiary = table.Column<double>(type: "float", nullable: true),
                    FEE_Domestic = table.Column<double>(type: "float", nullable: true),
                    FEE_Primary = table.Column<double>(type: "float", nullable: true),
                    FEE_Energetic = table.Column<double>(type: "float", nullable: true),
                    FEEI_PublicWorksConsumption = table.Column<double>(type: "float", nullable: true),
                    FEEI_IronSteelFoundry = table.Column<double>(type: "float", nullable: true),
                    FEEI_Metallurgy = table.Column<double>(type: "float", nullable: true),
                    FEEI_GlassIndustry = table.Column<double>(type: "float", nullable: true),
                    FEEI_CementLimeGypsum = table.Column<double>(type: "float", nullable: true),
                    FEEI_OtherConstructionMaterials = table.Column<double>(type: "float", nullable: true),
                    FEEI_ChemicalPetrochemical = table.Column<double>(type: "float", nullable: true),
                    FEEI_TransportMediumConstruction = table.Column<double>(type: "float", nullable: true),
                    FEEI_OtherMetalTransformation = table.Column<double>(type: "float", nullable: true),
                    FEEI_FoodBeverageTobacco = table.Column<double>(type: "float", nullable: true),
                    FEEI_TextileClothingLeatherFootwear = table.Column<double>(type: "float", nullable: true),
                    FEEI_PulpPaperCardboard = table.Column<double>(type: "float", nullable: true),
                    FEEI_OtherIndustries = table.Column<double>(type: "float", nullable: true),
                    DGGN_FrontierPointEnagas = table.Column<double>(type: "float", nullable: false),
                    DGGN_LNGDistributionSupply = table.Column<double>(type: "float", nullable: false),
                    DGGN_ThermalPowerPlantGNCConsumption = table.Column<double>(type: "float", nullable: false),
                    CCAC_AutoGasoline = table.Column<double>(type: "float", nullable: false),
                    CCAC_AutoDieselA = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyIndicator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Simulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Energy = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Ratio = table.Column<double>(type: "float", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simulations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterConsumption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    RegionID = table.Column<int>(type: "int", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    DomesticNET = table.Column<int>(type: "int", nullable: false),
                    EconomicActivities = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    DomesticConsumption = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterConsumption", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyIndicator");

            migrationBuilder.DropTable(
                name: "Simulations");

            migrationBuilder.DropTable(
                name: "WaterConsumption");
        }
    }
}
