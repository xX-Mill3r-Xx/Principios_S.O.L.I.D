namespace SOLID._02_OCP.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // debitar conta corrente
            return NumeroTransacao;
        }
    }
}
