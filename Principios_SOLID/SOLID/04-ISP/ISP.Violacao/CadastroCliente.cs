using System;

namespace SOLID._04_ISP.ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            throw new NotImplementedException();
            // envia email para o cliente
        }

        public void SalvarBanco()
        {
            throw new NotImplementedException();
            // insert na tabela
        }

        public void ValidarDados()
        {
            throw new NotImplementedException();
            // valida os dados
        }
    }
}
