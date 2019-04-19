using Dominio.Contratos;
using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacao
{
    public class VeiculoServico : IVeiculoServico
    {
        private IVeiculoRepositorio veiculoRepositorio;

        public VeiculoServico(IVeiculoRepositorio veiculoRepositorio)
        {
            this.veiculoRepositorio = veiculoRepositorio;
        }

        public Veiculo Add(Veiculo veiculo)
        {
            return veiculoRepositorio.Add(veiculo);
        }

        public List<Veiculo> GetAll()
        {
            return veiculoRepositorio.GetAll();
        }

        public Veiculo Update(Veiculo veiculo)
        {
            return veiculoRepositorio.Update(veiculo);
        }

        public Veiculo Get(int? id)
        {
            int veiculoId = 0;
            int.TryParse(id.ToString(), out veiculoId);

            return veiculoRepositorio.Get(veiculoId);
        }

        public void Delete(Veiculo veiculo)
        {
            veiculoRepositorio.Delete(veiculo);
        }
    }
}
