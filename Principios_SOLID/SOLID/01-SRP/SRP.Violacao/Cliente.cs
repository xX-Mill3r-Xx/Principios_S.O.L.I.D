using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID._01_SRP.SRP.Violacao
{
    public class Cliente
    {
        #region Properties

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        #endregion

        public string AdicionarCliente()
        {
            #region violação pois da ao método de como o email é validado

            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            #endregion

            #region violação pois da ao método de como o CPF é validado

            if (CPF.Length != 11)
                return "Cliente com CPF inválido";

            #endregion

            #region violação pois da ao método a responsabilidade de persistência

            using (var cn = new SqlConnection())
            {
                // Lógica para adicionar o cliente ao banco de dados
            }

            #endregion

            #region violação pois da ao método a responsabilidade de envio de email

            // Enviar e-mail de boas-vindas
            var mail = new MailMessage("empresa@empresa.com", Email);
            var cliente = new SmtpClient
            {
                // logica para enviar e-mail
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.empresa.com"
            };

            mail.Subject = "Bem-vindo!";
            mail.Body = $"Olá {Nome}, obrigado por se cadastrar!";
            cliente.Send(mail);

            #endregion

            return "Cliente adicionado com sucesso!";
        }
    }
}
