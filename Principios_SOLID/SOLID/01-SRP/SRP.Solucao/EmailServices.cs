namespace SOLID._01_SRP.SRP.Solucao
{
    public static class EmailServices
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
