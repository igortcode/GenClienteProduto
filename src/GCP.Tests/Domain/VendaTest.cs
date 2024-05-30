using GCP.Core.Enums;

namespace GCP.Tests.Domain
{
    public class VendaTest
    {
        [Fact(DisplayName = "Criar objeto Venda com estado válido")]
        public void CriarVenda_ComParametrosValidos_ObjetoComEstadoValido()
        {
            var action = () => new Venda(1, 123.12m, TipoPagamento.Credito);

            action.Should().NotThrow<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Venda com identificador do cliente inválido")]
        public void CriarVenda_IdClienteInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Venda(0, 123.12m, TipoPagamento.Credito);

            action.Should().Throw<DomainExceptionValidate>();
        }

        [Fact(DisplayName = "Criar objeto Venda com valor total inválido")]
        public void CriarVenda_ValorTotalInvalido_ObjetoComEstadoInvalido()
        {
            var action = () => new Venda(1, 0, TipoPagamento.Credito);

            action.Should().Throw<DomainExceptionValidate>();
        }
    }
}
