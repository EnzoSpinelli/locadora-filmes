using LocadoraFilmes.Web.Models;

namespace LocadoraFilmes.Web.Interfaces
{
    public interface IClienteService
    {
        Cliente GetClienteById(int id);
        IEnumerable<Cliente> GetAllClientes();
        void SaveCliente(Cliente cliente);
        void DeleteCliente(int id);
    }

    public interface IFilmeService
    {
        Filme GetFilmeById(int id);
        IEnumerable<Filme> GetAllFilmes();
        void SaveFilme(Filme filme);
        void DeleteFilme(int id);
    }

    public interface ILocacaoService
    {
        Locacao GetLocacaoById(int id);
        IEnumerable<Locacao> GetAllLocacoes();
        void SaveLocacao(Locacao locacao);
        void DeleteLocacao(int id);
    }

    public interface IUsuarioService
    {  Usuario GetUsuarioById(int id);      
       IEnumerable<Usuario> GetAllUsuarios();
        void SaveUsuario(Usuario usuario);
        void DeleteUsuario(int id);
    
    
    }

}
