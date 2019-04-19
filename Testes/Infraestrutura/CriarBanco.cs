using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infraestrutura.Contexto;
using Dominio.Entidades;
using System.Data.Entity;

namespace Testes.Infraestrutura
{
    /// <summary>
    /// Descrição resumida para CriarBanco
    /// </summary>
    [TestClass]
    public class CriarBanco<T> : DropCreateDatabaseAlways<EmpresaContext>
    {
        protected override void Seed(EmpresaContext context)
        {

            for (int i = 1; i <= 10; i++)
            {
                Email email = new Email();
                email.ValidarEmail("teste@teste.com.br");

                List<Veiculo> listVeiculos = new List<Veiculo>();
                var veiculos = new Veiculo("MMM-6666", "999999999");
                listVeiculos.Add(veiculos);

                var cliente = new Cliente("Teste", "99999999", email, listVeiculos);                

                context.Clientes.Add(cliente);
            }

            context.SaveChanges();
        }
    }
}
