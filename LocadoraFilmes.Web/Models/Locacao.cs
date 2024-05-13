namespace LocadoraFilmes.Web.Models
{
    public class Locacao // locacao cs
    {
        public int LocacaoId { get; set; }
        public int ClienteId { get; set; }
        public int FilmeId { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Filme Filme { get; set; }
    }
}
