using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infraestrutura.Contexto;
using Infraestrutura.Repositorios;
using Dominio.Entidades;
using Dominio.Contratos;
using System.Data.Entity;

namespace Testes.Infraestrutura
{
    /// <summary>
    /// Descrição resumida para EmpresaRepositoryTeste
    /// </summary>
    [TestClass]
    public class ClienteRepositorioTeste
    {
        private EmpresaContext _ctx;

        [TestInitialize]
        public void Initialize()
        {
            // Configura a estratégia de criação do banco que será usada no teste
            Database.SetInitializer(new CriarBanco<EmpresaContext>());

            // Cria uma instancia do contexto que será usada no teste
            _ctx = new EmpresaContext();

            // Inicializa a execução da estratégia de criação do banco de dados
            _ctx.Database.Initialize(true);
        }

        [TestMethod]
        public void Cliente_Repository_Add_Test()
        {
            // Arrange
            IClienteRepositorio repository = new ClienteRepositorio(_ctx);
            Email email = new Email();
            email.ValidarEmail("teste@teste.com.br");
            List<Veiculo> listVeiculos = new List<Veiculo>();
            var veiculo = new Veiculo("MMM-6666", "999999999");
            listVeiculos.Add(veiculo);
            var cliente = new Cliente("Cliente", "999999999", email, listVeiculos);

            // Action
            Cliente newCliente = repository.Add(cliente);

            // Assert
            Assert.IsTrue(newCliente.Id > 0);
        }

        [TestMethod]
        public void Cliente_Repository_Get_Test()
        {
            EmpresaContext context = new EmpresaContext();
            IClienteRepositorio repository = new ClienteRepositorio(context);

            Cliente cliente = repository.Get(1);

            Assert.IsNotNull(cliente);
        }

        [TestMethod]
        public void Cliente_Repository_GetAll_Test()
        {
            EmpresaContext context = new EmpresaContext();
            IClienteRepositorio repository = new ClienteRepositorio(context);

            List<Cliente> clientes = repository.GetAll();

            Assert.AreEqual(10, clientes.Count);
        }

        [TestMethod]
        public void Cliente_Repository_Update_Test()
        {
            EmpresaContext context = new EmpresaContext();
            IClienteRepositorio repository = new ClienteRepositorio(context);

            Cliente cliente = repository.Get(1);

            cliente.SetaNome("Teste");

            Cliente updatedCliente = repository.Update(cliente);

            Assert.AreEqual(updatedCliente.Nome, cliente.Nome);
        }

        [TestMethod]
        public void Cliente_Repository_Delete_Test()
        {
            EmpresaContext context = new EmpresaContext();
            IClienteRepositorio repository = new ClienteRepositorio(context);

            Cliente cliente = repository.Get(1);

            repository.Delete(cliente);

            Cliente deletedCliente = repository.Get(1);

            Assert.IsNull(deletedCliente);
        }
    }
}
