using System.ComponentModel.DataAnnotations;

namespace CrudJoalheria.Models
{
	public class JoiaModel
	{
		public int Id { get; set; }

		[Required (ErrorMessage = "Digite o campo do Tipo")]
		public string Tipo { get; set; }

        [Required(ErrorMessage = "Digite o campo do Material")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Digite o campo do Peso")]
        public double Peso { get; set;}

        [Required(ErrorMessage = "Digite o campo do Valor")]
        public double Valor { get; set;}
	}
}
