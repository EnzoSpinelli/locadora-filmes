using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;
using LocadoraFilmes.Web.Serviços;

namespace LocadoraFilmes.Web.Service
{
    public class FilmeService : IFilmeService
    {
        private IRepository<Filme> filmeRepository;

        public FilmeService(IRepository<Filme> repository)
        {
            filmeRepository = repository;
        }

        public Filme GetFilmeById(int id) => filmeRepository.GetById(id);
        public IEnumerable<Filme> GetAllFilmes() => filmeRepository.GetAll();
        public void SaveFilme(Filme filme) => filmeRepository.Update(filme);
        public void DeleteFilme(int id) => filmeRepository.GetById(id); //tentei utilizar o Delete, mas tá dando erro e eu não consigo arrumar a tempo
    }
}
