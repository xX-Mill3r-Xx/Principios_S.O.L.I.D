namespace SOLID._05_DIP.DIP.Violacao
{
    public class EmailServices
    {
        public static bool IsValid(string email)
        {
            // lógica de validação de email
            return email.Contains("@");
        }

        public static void Enviar(string de, string para, string assunto, string message)
        {
            //logica para envio de email
        }
    }
}
