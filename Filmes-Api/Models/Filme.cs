using System.ComponentModel.DataAnnotations;

namespace Filmes_Api.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
    }
}
