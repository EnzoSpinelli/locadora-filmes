

using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;
using LocadoraFilmes.Web.Serviços;

namespace LocadoraFilmes.Web.Service
    {
    public class UsuarioService : IUsuarioService
    {
        private IRepository<Usuario> usuarioRepository;

        public UsuarioService(IRepository<Usuario> repository)
        {
            usuarioRepository = repository;
        }

        public Usuario GetUsuarioById(int id) => usuarioRepository.GetById(id);
        public IEnumerable<Usuario> GetAllUsuarios() => usuarioRepository.GetAll();
        public void SaveUsuario(Usuario usuario) => usuarioRepository.Update(usuario);
        public void DeleteUsuario(int id) => usuarioRepository.GetById(id);//tentei utilizar o Delete, mas tá dando erro e eu não consigo arrumar a tempo
    }
}
