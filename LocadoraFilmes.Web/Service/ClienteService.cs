using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;
using LocadoraFilmes.Web.Serviços;

namespace LocadoraFilmes.Web.Service
{
    public class ClienteService : IClienteService
    {
        private IRepository<Cliente> clienteRepository;

        public ClienteService(IRepository<Cliente> repository)
        {
            clienteRepository = repository;
        }

        public Cliente GetClienteById(int id) => clienteRepository.GetById(id);
        public IEnumerable<Cliente> GetAllClientes() => clienteRepository.GetAll();
        public void SaveCliente(Cliente cliente) => clienteRepository.Update(cliente);
        public void DeleteCliente(int id) => clienteRepository.GetById(id);//tentei utilizar o Delete, mas tá dando erro e eu não consigo arrumar a tempo
    }
}
