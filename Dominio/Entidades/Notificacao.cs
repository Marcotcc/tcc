using System;

namespace Dominio.Entidades
{
    public class Notificacao
    {
        public Notificacao() { }
        public Notificacao(DateTime data_consulta, string notificacao, int enviar, int id_veiculo)
        {
            Data_Consulta = data_consulta;
            Mensagem_Notificacao = notificacao;
            Enviar = enviar;
            Id_Veiculo = id_veiculo;
        }
        public int Id { get; private set; }
        public DateTime Data_Consulta { get; set; }
        public string Mensagem_Notificacao { get; set; }
        public int Id_Veiculo { get; set; }
        public int Enviar { get; private set; }
        
    }
}
