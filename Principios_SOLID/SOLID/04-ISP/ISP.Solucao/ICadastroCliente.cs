namespace SOLID._04_ISP.ISP.Solucao
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}
