using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class CadastroanimalModel
    { //modelo do banco de dados
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o campo do Nome do Dono")]
        public string NomeDono { get; set; }

        [Required(ErrorMessage = "Digite o campo do Nome do Animal")]
        public string NomeAnimal { get; set; }

        [Required(ErrorMessage = "Digite o campo da Raça do Animal")]
        public string RacaAnimal { get; set; }

        [Required(ErrorMessage = "Digite o campo do Funcionario")]
        public string NomeFuncionario { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;


    }
}