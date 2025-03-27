using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcoEnergyRazorBBDD.Models
{
    public class EnergySystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public enum EnergyType
        {
            SolarEnergy,
            HydroElectricEnergy,
            EolicEnergy
        }
        public EnergyType Type { get; set; }
        public DateTime Date { get; set; }
        public double Energy { get; set; }
        public double Price { get; set; }
        public double Ratio { get; set; }
        public double Cost { get; set; }
        public double TotalCost { get; set; }
        public double TotalPrice { get; set; }
        public static int SimulationNumber { get; set; }
        public double GetEnergy() => Energy;
        public DateTime GetDate() => Date;
        public EnergyType GetEnergyType() => Type;
        public double CalculateTotalCost() => Cost * Energy;
        public double CalculateTotalPrice() => Price * Energy;
        public double CalculateRatio() => TotalPrice / TotalCost;

    }
}
