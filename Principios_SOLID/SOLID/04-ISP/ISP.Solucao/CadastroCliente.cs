using System;

namespace SOLID._04_ISP.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            throw new NotImplementedException();
            // envia email ao cliente
        }

        public void SalvarBanco()
        {
            throw new NotImplementedException();
            // insert no banco
        }

        public void ValidarDados()
        {
            throw new NotImplementedException();
            // valida os dados
        }
    }
}
