namespace SOLID._01_SRP.SRP.Solucao
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            // lógica de validação de CPF
            return cpf.Length == 11;
        }
    }
}
