using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Entidades;
using Moq;
using Dominio.Contratos;
using Aplicacao;

namespace Testes.Aplicação
{
    /// <summary>
    /// Descrição resumida para ClienteServiceTeste
    /// </summary>
    [TestClass]
    public class ClienteServiceTeste
    {
        [TestMethod]
        public void Cliente_Service_Add_Test()
        {
            // Arrange 
            Email email = new Email();
            email.ValidarEmail("teste@teste.com.br");
            List<Veiculo> listVeiculos = new List<Veiculo>();
            var veiculo = new Veiculo("MMM-6666", "999999999");
            listVeiculos.Add(veiculo);
            var cliente = new Cliente("Marco Antonio", "999999999", email, listVeiculos);

            Mock<IClienteRepositorio> repositoryFake = new Mock<IClienteRepositorio>();
            repositoryFake.Setup(x => x.Add(cliente)).Returns(cliente);

            IClienteServico service = new ClienteServico(repositoryFake.Object);
            //Action
            var newCliente = service.Add(cliente);

            //Assert
            repositoryFake.Verify(x => x.Add(cliente));
        }

        [TestMethod]
        public void Cliente_Service_Update_Test()
        {
            // Arrange
            Email email = new Email();
            email.ValidarEmail("teste@teste.com.br");
            List<Veiculo> listVeiculos = new List<Veiculo>();
            var veiculo = new Veiculo("MMM-6666", "999999999");
            listVeiculos.Add(veiculo);
            var cliente = new Cliente("Marco Antonio", "999999999", email, listVeiculos);


            Mock<IClienteRepositorio> repositoryFake = new Mock<IClienteRepositorio>();
            repositoryFake.Setup(repository => repository.Update(cliente)).Returns(cliente);

            IClienteServico service = new ClienteServico(repositoryFake.Object);
            //Action
            var updatedCliente = service.Update(cliente);

            //Assert
            repositoryFake.Verify(repository => repository.Update(cliente));
        }

        [TestMethod]
        public void Cliente_Service_GetAll_Test()
        {
            //Arrange
            List<Cliente> listClientes = new List<Cliente>();
            Mock<IClienteRepositorio> repositoryFake = new Mock<IClienteRepositorio>();
            repositoryFake.Setup(repository => repository.GetAll()).Returns(listClientes);

            IClienteServico service = new ClienteServico(repositoryFake.Object);
            //Action
            var list = service.GetAll();

            //Assert
            repositoryFake.Verify(repository => repository.GetAll());
        }
    }
}
