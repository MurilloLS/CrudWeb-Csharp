using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrudWeb.Models
{
    public class Movimentacao
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }


        [Display(Name = "Conteiner Id")]
        [Column("Conteiner_Id")]
        public string Conteiner_Id { get; set; }


        [Display(Name = "Procedimento")]
        [Column("Procedimento")]
        public string Procedimento { get; set; }


        [Display(Name = "Data e Hora iniciais")]
        [Column("DH_Inicais")]
        public DateTime DH_Iniciais { get; set; }

        [Display(Name = "Data e Hora finais")]
        [Column("DH_Finais")]
        public DateTime DH_Finais { get; set; }
    }
}
