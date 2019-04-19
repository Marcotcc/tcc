using System;

namespace Dominio.Entidades
{
    public class Veiculo
    {
        public Veiculo() { }
        public Veiculo(string placa, string renavan)
        {
            Placa = placa;
            Renavan = renavan;

            if (placa == null)
                throw new ArgumentNullException();

            if (renavan == null)
                throw new ArgumentNullException();
            
        }
        public int Id { get; private set; }
        public string Placa { get; set; }
        public string Renavan { get; set; }
        
    }
}
