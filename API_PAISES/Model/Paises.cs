using System;
using System.ComponentModel.DataAnnotations;

namespace API_PAISES.Model
{
    public class Paises
    {
        [Key]   
        public int Id { get; set; }
        [Required]
        public String Pais  { get; set; }
        [Required]
        public String Capital { get; set; }
        public String Moeda { get; set; }
        public double Populacao { get; set; }
        public String Continente { get; set; }
    }
}
