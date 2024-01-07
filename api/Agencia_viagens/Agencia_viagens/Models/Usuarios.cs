using System.ComponentModel.DataAnnotations;

namespace Agencia_viagens.Models
{
    public class Usuarios
    {
        [Key]
        public int id_cliente { get; set; }
       
        public string nomecompleto { get; set; }
        [Required(ErrorMessage ="O  nome é obrigatório")]
        [MinLength(6, ErrorMessage = "Este campo deve conter pelo menos 6 caracteres")]
        public string endereco { get; set; }

        public string cep { get; set; }

        public string cpf { get; set; }

        public string e_mail { get; set; }

        public string senha { get; set; }

        public string telefone { get; set; }

        public string datacadastro { get; set; }

    }
}
