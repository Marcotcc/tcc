using Dominio.Contratos;
using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacao
{
    public class ClienteServico : IClienteServico
    {
        private IClienteRepositorio clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            this.clienteRepositorio = clienteRepositorio;
        }

        public Cliente Add(Cliente cliente)
        {
            return clienteRepositorio.Add(cliente);
        }

        public List<Cliente> GetAll()
        {
            return clienteRepositorio.GetAll();
        }

        public Cliente Update(Cliente cliente)
        {
            return clienteRepositorio.Update(cliente);
        }

        public Cliente Get(int? id)
        {
            int clienteId = 0;
            int.TryParse(id.ToString(), out clienteId);

            return clienteRepositorio.Get(clienteId);
        }

        public void Delete(Cliente cliente)
        {
            clienteRepositorio.Delete(cliente);
        }
    }
}
