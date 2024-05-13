using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;

namespace LocadoraFilmes.Web.Serviços
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    // UsuarioService.cs
    public class UsuarioService : IUsuarioService
    {
        private IRepository<Usuario> repository;

        public UsuarioService(IRepository<Usuario> repo)
        {
            repository = repo;
        }

        public Usuario GetUsuarioById(int id) => repository.GetById(id);
        public IEnumerable<Usuario> GetAllUsuarios() => repository.GetAll();
        public void SaveUsuario(Usuario usuario)
        {
            if (usuario.UsuarioId == 0) repository.Add(usuario);
            else repository.Update(usuario);
        }
        public void DeleteUsuario(int id)
        {
            var usuario = repository.GetById(id);
            if (usuario != null) repository.Delete(usuario);
        }
    }
}
