using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacao
{
    public interface IVeiculoServico
    {
        Veiculo Add(Veiculo veiculo);
        Veiculo Update(Veiculo veiculo);
        List<Veiculo> GetAll();
    }
}
