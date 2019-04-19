using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacao
{
    public interface IClienteServico
    {
        Cliente Add(Cliente cliente);
        Cliente Update(Cliente cliente);
        List<Cliente> GetAll();
    }
}
