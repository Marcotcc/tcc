using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Entidades;

namespace Testes.Domínio
{
    /// <summary>
    /// Descrição resumida para VeiculoTeste
    /// </summary>
    [TestClass]
    public class VeiculoTeste
    {

        [TestMethod]
        public void Veiculo_Domain_Valid_Test()
        {
            // Arrange 
            var veiculo = new Veiculo("MMM6666", "999999999");

            Assert.IsNotNull(veiculo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Veiculo_Domain_RenavamNull_Test()
        {
            // Arrange
            var veiculo = new Veiculo("MMM6666", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Veiculo_Domain_PlacaNull_Test()
        {
            // Arrange
            var veiculo = new Veiculo(null, "999999999");
        }
    }
}
