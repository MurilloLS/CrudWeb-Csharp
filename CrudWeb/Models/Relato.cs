using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrudWeb.Models
{
    public class Relato
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Cliente")]
        [Column("Cliente")]
        public string Cliente { get; set; }

        [Display(Name = "Tipo")]
        [Column("Tipo")]
        public int Tipo { get; set; }

        [Display(Name = "Procedimento")]
        [Column("Procedimento")]
        public string Procedimento { get; set; }
    }
}
