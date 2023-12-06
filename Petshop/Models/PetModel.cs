using System.ComponentModel.DataAnnotations;

namespace petshop.Models
{
    public class PetModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o campo Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o campo Raça")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Digite o campo Especie")]
        public string Especie { get; set; }

        [Required(ErrorMessage = "Digite o campo Peso")]
        public string Peso { get; set; }
    }
 }
