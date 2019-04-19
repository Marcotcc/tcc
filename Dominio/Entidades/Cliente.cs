using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(string nome, string telefone, Email email, List<Veiculo> veiculos)
        {
            SetaNome(nome);
            Telefone = telefone;
            Email = email;
            Veiculos = veiculos;

            if (nome == null)
                throw new ArgumentNullException();

            if (telefone == null)
                throw new ArgumentNullException();

            if (email == null)
                throw new ArgumentNullException();

            if (veiculos == null)
                throw new ArgumentNullException();
            
        }
        public int Id { get; private set; }
        public string Telefone { get; set; }
        public Email Email { get; set; }
        public List<Veiculo> Veiculos { get; set; }
        public string Nome { get; private set; }
        public void SetaNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException();
            Nome = nome;
        }
    }
}
