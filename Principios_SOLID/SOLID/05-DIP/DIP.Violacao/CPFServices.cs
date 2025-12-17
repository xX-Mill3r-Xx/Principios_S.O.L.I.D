namespace SOLID._05_DIP.DIP.Violacao
{
    public class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            // lógica de validação de CPF
            return cpf.Length == 11;
        }
    }
}
