using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Entidades;
using Dominio.Contratos;
using Aplicacao;
using Moq;

namespace Testes.Aplicação
{
    /// <summary>
    /// Descrição resumida para VeiculoServiceTeste
    /// </summary>
    [TestClass]
    public class VeiculoServiceTeste
    {
        [TestMethod]
        public void Veiculo_Service_Add_Test()
        {
            // Arrange   
            var empresa = new Veiculo("MMM8558", "999999999");

            Mock<IVeiculoRepositorio> repositoryFake = new Mock<IVeiculoRepositorio>();
            repositoryFake.Setup(x => x.Add(empresa)).Returns(empresa);

            IVeiculoServico service = new VeiculoServico(repositoryFake.Object);
            //Action
            var newVeiculo = service.Add(empresa);

            //Assert
            repositoryFake.Verify(x => x.Add(empresa));
        }

        [TestMethod]
        public void Veiculo_Service_Update_Test()
        {
            // Arrange
            var empresa = new Veiculo("MMM8558", "999999999");


            Mock<IVeiculoRepositorio> repositoryFake = new Mock<IVeiculoRepositorio>();
            repositoryFake.Setup(repository => repository.Update(empresa)).Returns(empresa);

            IVeiculoServico service = new VeiculoServico(repositoryFake.Object);
            //Action
            var updatedVeiculo = service.Update(empresa);

            //Assert
            repositoryFake.Verify(repository => repository.Update(empresa));
        }

        [TestMethod]
        public void Veiculo_Service_GetAll_Test()
        {
            //Arrange
            List<Veiculo> listVeiculos = new List<Veiculo>();
            Mock<IVeiculoRepositorio> repositoryFake = new Mock<IVeiculoRepositorio>();
            repositoryFake.Setup(repository => repository.GetAll()).Returns(listVeiculos);

            IVeiculoServico service = new VeiculoServico(repositoryFake.Object);
            //Action
            var list = service.GetAll();

            //Assert
            repositoryFake.Verify(repository => repository.GetAll());
        }
    }
}
