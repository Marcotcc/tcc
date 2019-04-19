using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Contratos
{
    public interface IVeiculoRepositorio
    {
        Veiculo Add(Veiculo veiculo);
        Veiculo Get(int id);
        List<Veiculo> GetAll();
        Veiculo Update(Veiculo veiculo);
        void Delete(Veiculo veiculo);
    }
}
