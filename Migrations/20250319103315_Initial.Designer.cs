﻿// <auto-generated />
using System;
using EcoEnergyRazorBBDD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcoEnergyRazorBBDD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250319103315_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcoEnergyRazorBBDD.Models.EnergyIndicator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("CCAC_AutoDieselA")
                        .HasColumnType("float");

                    b.Property<double>("CCAC_AutoGasoline")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_AuxConsumption")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_AvailableProduction")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_ElectricDemand")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_ElectricExchangeBalance")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_GrossProduction")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_NetProduction")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_PumpConsumption")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_TotalFreeMarket")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_TotalNetworkSalesCentral")
                        .HasColumnType("float");

                    b.Property<double>("CDEEBC_TotalRegulatedMarket")
                        .HasColumnType("float");

                    b.Property<double>("DGGN_FrontierPointEnagas")
                        .HasColumnType("float");

                    b.Property<double>("DGGN_LNGDistributionSupply")
                        .HasColumnType("float");

                    b.Property<double>("DGGN_ThermalPowerPlantGNCConsumption")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("FEEI_CementLimeGypsum")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_ChemicalPetrochemical")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_FoodBeverageTobacco")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_GlassIndustry")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_IronSteelFoundry")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_Metallurgy")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_OtherConstructionMaterials")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_OtherIndustries")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_OtherMetalTransformation")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_PublicWorksConsumption")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_PulpPaperCardboard")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_TextileClothingLeatherFootwear")
                        .HasColumnType("float");

                    b.Property<double?>("FEEI_TransportMediumConstruction")
                        .HasColumnType("float");

                    b.Property<double?>("FEE_Domestic")
                        .HasColumnType("float");

                    b.Property<double?>("FEE_Energetic")
                        .HasColumnType("float");

                    b.Property<double?>("FEE_Industry")
                        .HasColumnType("float");

                    b.Property<double?>("FEE_Primary")
                        .HasColumnType("float");

                    b.Property<double?>("FEE_Tertiary")
                        .HasColumnType("float");

                    b.Property<double>("PBEE_Coal")
                        .HasColumnType("float");

                    b.Property<double>("PBEE_CombinedCycle")
                        .HasColumnType("float");

                    b.Property<double>("PBEE_FuelOil")
                        .HasColumnType("float");

                    b.Property<double>("PBEE_Hydroelectric")
                        .HasColumnType("float");

                    b.Property<double>("PBEE_NaturalGas")
                        .HasColumnType("float");

                    b.Property<double>("PBEE_Nuclear")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("EnergyIndicator");
                });

            modelBuilder.Entity("EcoEnergyRazorBBDD.Models.EnergySystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Energy")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Ratio")
                        .HasColumnType("float");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Simulacions");
                });

            modelBuilder.Entity("EcoEnergyRazorBBDD.Models.WaterConsumptionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DomesticConsumption")
                        .HasColumnType("float");

                    b.Property<int>("DomesticNET")
                        .HasColumnType("int");

                    b.Property<int>("EconomicActivities")
                        .HasColumnType("int");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WaterConsumption");
                });
#pragma warning restore 612, 618
        }
    }
}
