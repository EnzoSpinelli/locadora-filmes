using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;

namespace LocadoraFilmes.Web.Serviços
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
        public void SaveCliente(Cliente cliente)
        {
            if (cliente.ClienteId == 0) clienteRepository.Add(cliente);
            else clienteRepository.Update(cliente);
        }
        public void DeleteCliente(int id)
        {
            var cliente = clienteRepository.GetById(id);
            if (cliente != null) clienteRepository.Delete(cliente);
        }
    }

}
