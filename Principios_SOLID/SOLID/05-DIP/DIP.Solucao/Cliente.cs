using SOLID._05_DIP.DIP.Solucao.Interfaces;
using System;

namespace SOLID._05_DIP.DIP.Solucao
{
    public class Cliente
    {
        private readonly ICPFServices _cPFServices;
        private readonly IEmailServices _emailServices;

        #region Properties

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        #endregion

        public Cliente(ICPFServices cPFServices, IEmailServices emailServices)
        {
            _cPFServices = cPFServices;
            _emailServices = emailServices;
        }

        public bool IsValid()
        {
            return _emailServices.IsValid(Email) && _cPFServices.IsValid(CPF); 
        }
    }
}
