using APIPrincipal.Models;

namespace APIPrincipal.DTOs
{
    public class GamesRequestDto
    {
        public string Nome { get; set; }
        public Plataforma Plataforma { get; set; }
    }
}
