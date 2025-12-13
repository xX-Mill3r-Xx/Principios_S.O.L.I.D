namespace SOLID._02_OCP.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // debitar conta investimento
            //inserir taxas
            return NumeroTransacao;
        }
    }
}
