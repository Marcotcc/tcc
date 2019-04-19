using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Entidades;

namespace Testes.Domínio
{
    /// <summary>
    /// Descrição resumida para ClienteTeste
    /// </summary>
    [TestClass]
    public class ClienteTeste
    {
        private Cliente _cliente;

        [TestInitialize]
        public void Initialize()
        {
            Email email = new Email();
            email.ValidarEmail("teste@teste.com.br");
            List<Veiculo> listVeiculos = new List<Veiculo>();
            var veiculo = new Veiculo("MMM-6666", "999999999");
            listVeiculos.Add(veiculo);
            _cliente = new Cliente("Marco Antonio", "999999999", email, listVeiculos);
        }

        [TestMethod]
        public void Cliente_Domain_Valid_Test()
        {
            // Arrange
            Email email = new Email();
            email.ValidarEmail("teste@teste.com.br");
            List<Veiculo> listVeiculos = new List<Veiculo>();
            var veiculo = new Veiculo("MMM-6666", "999999999");
            listVeiculos.Add(veiculo);
            var cliente = new Cliente("Marco Antonio", "999999999", email, listVeiculos);

            Assert.IsNotNull(cliente);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cliente_Domain_NameNull_Test()
        {
            // Arrange
            Email email = new Email();
            email.ValidarEmail("teste@teste.com.br");
            List<Veiculo> listVeiculos = new List<Veiculo>();
            var veiculo = new Veiculo("MMM-6666", "999999999");
            listVeiculos.Add(veiculo);
            var cliente = new Cliente("", "999999999", email, listVeiculos);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cliente_Domain_Null_Telefone_Test()
        {
            // Arrange
            Email email = new Email();
            email.ValidarEmail("teste@teste.com.br");
            List<Veiculo> listVeiculos = new List<Veiculo>();
            var veiculo = new Veiculo("MMM-6666", "999999999");
            listVeiculos.Add(veiculo);
            var cliente = new Cliente("Marco Antonio", null, email, listVeiculos);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cliente_Domain_Null_Email_Test()
        {
            // Arrange
            List<Veiculo> listVeiculos = new List<Veiculo>();
            var veiculo = new Veiculo("MMM-6666", "999999999");
            listVeiculos.Add(veiculo);
            var cliente = new Cliente("Marco Antonio", "51651651", null, listVeiculos);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cliente_Domain_Null_Veiculo_Test()
        {
            // Arrange
            Email email = new Email();
            email.ValidarEmail("teste@teste.com.br");
            var cliente = new Cliente("Marco Antonio", "51651651", email, null);
        }
    }
}
