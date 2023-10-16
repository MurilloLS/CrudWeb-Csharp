using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWeb.Models
{
    [Table("Conteiner")]
    public class Conteiner
    {
        [Display(Name ="Código")]
        [Column("Id")]
        public int Id { get; set; }


        [Display(Name = "Cliente")]
        [Column("Cliente")]
        public string Cliente { get; set; }


        [Display(Name = "Número")]
        [Column("Numero")]
        public string Numero { get; set; }


        [Display(Name = "Tipo")]
        [Column("Tipo")]
        public int Tipo { get; set; }


        [Display(Name = "Status")]
        [Column("Status")]
        public string Status { get; set; }


        [Display(Name = "Categoria")]
        [Column("Categoria")]
        public string Categoria { get; set; }

    }
}
