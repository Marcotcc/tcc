using Dominio.Contratos;
using Dominio.Entidades;
using Infraestrutura.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Infraestrutura.Repositorios
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        private EmpresaContext _contexto;
        public VeiculoRepositorio(EmpresaContext contexto)
        {
            _contexto = contexto;
        }
        public Veiculo Add(Veiculo veiculo)
        {
            veiculo = _contexto.Veiculos.Add(veiculo);
            _contexto.SaveChanges();
            return veiculo;
        }
        public Veiculo Update(Veiculo veiculo)
        {
            var entry = _contexto.Entry(veiculo);
            entry.State = System.Data.Entity.EntityState.Added;
            _contexto.SaveChanges();
            return entry.Entity;
        }
        public void Delete(Veiculo veiculo)
        {
            _contexto.Veiculos.Remove(veiculo);
            _contexto.SaveChanges();
        }

        public Veiculo Get(int id)
        {
            return _contexto.Veiculos.Find(id);
        }

        public List<Veiculo> GetAll()
        {
            return _contexto.Veiculos.ToList();
        }

    }
}
