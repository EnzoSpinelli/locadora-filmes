namespace LocadoraFilmes.Web.Models
{
    public class Filme //Filme cs
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public int Ano { get; set; }
        public bool Disponivel { get; set; }
    }
}
