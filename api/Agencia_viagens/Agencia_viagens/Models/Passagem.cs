using System.ComponentModel.DataAnnotations;

namespace Agencia_viagens.Models
{
    public class Passagem
    {
        [Key]
        public int id_passsagem { get; set; }

        public string destino { get; set; }
        [Required(ErrorMessage = "O  deestino é obrigatório")]
        [MinLength(6, ErrorMessage = "Este campo deve conter pelo menos 6 caracteres")]
        public string data_de_ida { get; set; }

        public string data_de_volta { get; set; }

        public string empresa { get; set; }

        public string horario_da_ida { get; set; }

        public string horario_da_volta { get; set; }
 




    }
}