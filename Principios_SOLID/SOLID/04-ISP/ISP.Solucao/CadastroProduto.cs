using System;

namespace SOLID._04_ISP.ISP.Solucao
{
    public class CadastroProduto : ICadastroProduto
    {
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
