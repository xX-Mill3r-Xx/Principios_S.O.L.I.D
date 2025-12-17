namespace SOLID._05_DIP.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Cliente inválido";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            _01_SRP.SRP.Solucao.EmailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "parabens, está cadastrado");

            return "Cliente adicionado com sucesso";
        }
    }
}
