using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Contratos
{
    public interface IClienteRepositorio
    {
        Cliente Add(Cliente cliente);
        Cliente Get(int id);
        List<Cliente> GetAll();
        Cliente Update(Cliente cliente);
        void Delete(Cliente cliente);
    }
}
