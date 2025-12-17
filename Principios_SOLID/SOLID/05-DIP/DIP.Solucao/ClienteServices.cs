using SOLID._05_DIP.DIP.Solucao.Interfaces;

namespace SOLID._05_DIP.DIP.Solucao
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);
            _emailServices.Enviar("empresa@mail.com", cliente.Email, "Bem vindo", "parabens, está cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
