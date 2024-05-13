using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;

namespace LocadoraFilmes.Web.Serviços
{
    public class LocacaoService : ILocacaoService
    {
        private IRepository<Locacao> locacaoRepository;

        public LocacaoService(IRepository<Locacao> repository)
        {
            locacaoRepository = repository;
        }

        public Locacao GetLocacaoById(int id) => locacaoRepository.GetById(id);
        public IEnumerable<Locacao> GetAllLocacoes() => locacaoRepository.GetAll();
        public void SaveLocacao(Locacao locacao)
        {
            if (locacao.LocacaoId == 0) locacaoRepository.Add(locacao);
            else locacaoRepository.Update(locacao);
        }
        public void DeleteLocacao(int id)
        {
            var locacao = locacaoRepository.GetById(id);
            if (locacao != null) locacaoRepository.Delete(locacao);
        }
    }
}
