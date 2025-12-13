namespace SOLID._02_OCP.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // debitar conta corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // valida aniversario da conta
                // debitar conta poupança
            }
        }
    }
}
