using System.ComponentModel.DataAnnotations;

namespace SalaoCabeleireiro.Models
{
    public class HomeModel
    {
        [Required]
        public string Nome { get; set; }

        public string Email { get; set; }
    }
}
