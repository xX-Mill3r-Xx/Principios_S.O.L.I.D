using System;

namespace SOLID._05_DIP.DIP.Violacao
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

        public bool IsValid() // validação de email e CPF delegada para classes específicas
        {
            return _01_SRP.SRP.Solucao.EmailServices.IsValid(Email) && _01_SRP.SRP.Solucao.CPFServices.IsValid(CPF);
        }
    }
}
