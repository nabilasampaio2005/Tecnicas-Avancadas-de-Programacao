using System.ComponentModel.DataAnnotations;

namespace CrudJoalheria.Models
{
	public class ClienteModel
	{
		public int Id { get; set; }

        [Required(ErrorMessage = "Digite o campo Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o campo CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite o campo Endereco")]
        public string Endereco { get; set;}

        [Required(ErrorMessage = "Digite o campo Telefone")]
        public string Telefone { get; set;}
	}
}
