namespace GCP.Tests.Domain
{
    public class ClienteTests
    {
        [Fact(DisplayName = "Criar objeto Cliente com estado válido")]
        public void CriarCliente_ComParametrosValidos_ObjetoComEstadoValido()
        {
            var action = () => new Cliente("Teste", "144.162.010-95", GetEnderecoMoc(), "(99) 99999-9999", "teste@teste.com");

            action.Should().NotThrow<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Cliente com nome inválido")]
        public void CriarCliente_ComCampoNomeInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Cliente("", "144.162.010-95", GetEnderecoMoc(), "(99) 99999-9999", "teste@teste.com");

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Cliente(new string('a', 301), "144.162.010-95", GetEnderecoMoc(), "(99) 99999-9999", "teste@teste.com");

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Cliente(null, "144.162.010-95", GetEnderecoMoc(), "(99) 99999-9999", "teste@teste.com");

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Cliente com Cpf inválido")]
        public void CriarCliente_ComCampoCpfInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Cliente("Teste", "144.162.010-92", GetEnderecoMoc(), "(99) 99999-9999", "teste@teste.com");

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Cliente com Endereço inválido")]
        public void CriarCliente_ComEnderecoInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Cliente("Teste", "144.162.010-95", null, "(99) 99999-9999", "teste@teste.com");

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Cliente com Telefone inválido")]
        public void CriarCliente_ComCampoTelefoneInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Cliente("Teste", "144.162.010-95", GetEnderecoMoc(), "", "teste@teste.com");

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Cliente("Teste", "144.162.010-95", GetEnderecoMoc(), new string('1', 21), "teste@teste.com");

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Cliente("Teste", "144.162.010-95", GetEnderecoMoc(), null, "teste@teste.com");

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Cliente com Email inválido")]
        public void CriarCliente_ComCampoEmailInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Cliente("Teste", "144.162.010-95", GetEnderecoMoc(), "(99) 99999-9999", "");

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Cliente("Teste", "144.162.010-95", GetEnderecoMoc(), "(99) 99999-9999", new string('1', 101));

            action.Should().Throw<DomainExceptionValidate>();

            action = () => new Cliente("Teste", "144.162.010-95", GetEnderecoMoc(), "(99) 99999-9999", null);

            action.Should().Throw<DomainExceptionValidate>();
        }

        private EnderecoVO GetEnderecoMoc()
        {
            return new EnderecoVO("38.600.000", "Rua Teste", "Teste", "Teste", "MG", "Numero", "Complemento");
        }
    }
}
