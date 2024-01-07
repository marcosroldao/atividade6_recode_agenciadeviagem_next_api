using System.ComponentModel.DataAnnotations;

namespace Agencia_viagens.Models
{
    public class Reserva
    {
        [Key]
        public int id_reserva { get; set; }

        public string origem { get; set; }
        [Required(ErrorMessage = "A nome é obrigatória")]
        [MinLength(6, ErrorMessage = "Este campo deve conter pelo menos 6 caracteres")]
        public string destino { get; set; }

        public string data_de_ida { get; set; }


        public string data_de_volta { get; set; }

        public double preco { get; set; }
 


    }
}
