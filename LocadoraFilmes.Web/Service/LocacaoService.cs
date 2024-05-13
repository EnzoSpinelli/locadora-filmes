using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;
using LocadoraFilmes.Web.Serviços;

namespace LocadoraFilmes.Web.Service
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
        public void SaveLocacao(Locacao locacao) => locacaoRepository.Update(locacao);
        public void DeleteLocacao(int id) => locacaoRepository.GetById(id);//tentei utilizar o Delete, mas tá dando erro e eu não consigo arrumar a tempo
        public void GetAllClientes(int id) => locacaoRepository.GetAll();

    }

}
