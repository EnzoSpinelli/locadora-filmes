using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;

namespace LocadoraFilmes.Web.Serviços
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
        public void SaveFilme(Filme filme)
        {
            if (filme.FilmeId == 0) filmeRepository.Add(filme);
            else filmeRepository.Update(filme);
        }
        public void DeleteFilme(int id)
        {
            var filme = filmeRepository.GetById(id);
            if (filme != null) filmeRepository.Delete(filme);
        }
    }
}
