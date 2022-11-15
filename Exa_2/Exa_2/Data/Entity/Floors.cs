using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Exa_2.Data.Entity
{
    public class Floors
    {
        public int Id { get; set; }
        [Display(Name = "Nombre de la planta ")]
        [MaxLength(200, ErrorMessage = "En el campo {0} el maximo permitido son {1} caracteres")]
        public string Plant_Name { get; set; } = null!;
        [Display(Name = "Familia de la planta  ")]
        [MaxLength(200, ErrorMessage = "En el campo {0} el maximo permitido son {1} caracteres")]
        public string Plant_family { get; set; } = null!;


        [Display(Name = "Descripcion de la planta ")]
        [MaxLength(200, ErrorMessage = "En el campo {0} el maximo permitido son {1} caracteres")]
        public string Plant_Description { get; set; } = null!;
        [Display(Name = "Tipo de planta ")]
        [MaxLength(20, ErrorMessage = "En el campo {0} el maximo permitido son {1} caracteres")]
        public string? Plant_Type { get; set; } = null!;



        [Display(Name = "Años de la planta ")]
        [MaxLength(8, ErrorMessage = "En el campo {0} el maximo permitido son {1} caracteres")]

        public decimal? Plant_years { get; set; }

        [Display(Name = "Costo de la planta ")]
        public decimal? Plant_cost { get; set; }


        [Display(Name = "Fecha de plantacion ")]
        public DateTime? Planting_date { get; set; }

        [Display(Name = "Cantidad de plantines  ")]
        public Double? Planting_amount { get; set; }

        [Display(Name = "Planta vendida? ")]

        public bool? Plant_sold { set; get; }
        [Display(Name = "Es una planta medicinal? ")]
        public bool Medicinal_plants { set; get; }
        [Display(Name = "Es una planta de interiores? ")]
        public bool Indoor_plants { set; get; }

        public bool IsActivate { get; set; }
    }
}
