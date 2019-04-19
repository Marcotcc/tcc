using Dominio.Contratos;
using Dominio.Entidades;
using Infraestrutura.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Infraestrutura.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private EmpresaContext _contexto;

        public ClienteRepositorio(EmpresaContext contexto)
        {
            _contexto = contexto;
        }
        public Cliente Add(Cliente cliente)
        {
            cliente = _contexto.Clientes.Add(cliente);
            _contexto.SaveChanges();
            return cliente;
        }
        public Cliente Update(Cliente cliente)
        {
            var entry = _contexto.Entry(cliente);
            entry.State = System.Data.Entity.EntityState.Added;
            _contexto.SaveChanges();
            return entry.Entity;
        }
        public void Delete(Cliente cliente)
        {
            _contexto.Clientes.Remove(cliente);
            _contexto.SaveChanges();
        }

        public Cliente Get(int id)
        {
            return _contexto.Clientes.Find(id);
        }

        public List<Cliente> GetAll()
        {
            return _contexto.Clientes.ToList();
        }
    }
}
