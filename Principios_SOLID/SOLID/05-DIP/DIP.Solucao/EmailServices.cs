using SOLID._05_DIP.DIP.Solucao.Interfaces;

namespace SOLID._05_DIP.DIP.Solucao
{
    public class EmailServices : IEmailServices
    {
        public void Enviar(string de, string para, string assunto, string msg)
        {
            throw new System.NotImplementedException();
        }

        public bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
}
