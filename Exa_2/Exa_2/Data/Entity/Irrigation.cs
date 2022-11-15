using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Exa_2.Data.Entity
{
    public class Irrigation
    {
      public int Id { get; set; }
        [Required]

        [Display(Name = "Nombre de la plantacion  ")]
        public string Plantation_Name { get; set; } = null!;
        [Display(Name = "Descripcion de la plantacion  ")]
        public string Plantation_Description { get; set; } = null!;

        [Display(Name = "Tipo de plantacion  ")]
        public string Plantation_Type { get; set; } = null!;

        [Display(Name = "Tipo de tierra ")]
        public string? Type_land { get; set; } = null!;
        
        [Display(Name = "fecha de plantacion  ")]
        public DateTime? Plantation_Date { get; set; }
        [Display(Name = "fecha de riego")]
        public DateTime? Watering_date { get; set; }
       
        [Display(Name = "Cantidad de plantines  ")]
        public Double? Planting_amount { get; set; }
        public bool IsActivate { get; set; }




    }
}
