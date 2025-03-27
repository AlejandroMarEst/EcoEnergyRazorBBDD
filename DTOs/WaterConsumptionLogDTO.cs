using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEnergyRazorBBDD.DTOs
{
    public class WaterConsumptionLogDTO
    {
        [Required(ErrorMessage = "This field is necessary")]
        public int Year { get; set; }
        [Required(ErrorMessage = "This field is necessary")]
        public int RegionID { get; set; }
        [Required(ErrorMessage = "This field is necessary")]
        public string? RegionName { get; set; }
        [Required(ErrorMessage = "This field is necessary")]
        public int Population { get; set; }
        [Required(ErrorMessage = "This field is necessary")]
        public int DomesticNET { get; set; }
        [Required(ErrorMessage = "This field is necessary")]
        public int EconomicActivities { get; set; }
        [Required(ErrorMessage = "This field is necessary")]
        public int Total { get; set; }
        [Required(ErrorMessage = "This field is necessary")]
        public double DomesticConsumption { get; set; }
    }
}
