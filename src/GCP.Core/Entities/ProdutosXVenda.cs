using GCP.Core.Entities.Generic;
using GCP.Core.Validations.CustomExceptions;

namespace GCP.Core.Entities
{
    public sealed class ProdutosXVenda : Entity
    {
        public int ProdutoId { get; private set; }
        public int VendaId { get; private set; }
        public decimal PrecoProduto { get; private set; }
        public decimal QuantidadeProduto { get; private set; }

        public ProdutosXVenda(int produtoId, int vendaId, decimal precoProduto, decimal quantidadeProduto)
        {
            Validate(produtoId, vendaId, precoProduto, quantidadeProduto);

            ProdutoId = produtoId;
            VendaId = vendaId;
            PrecoProduto = precoProduto;
            QuantidadeProduto = quantidadeProduto;
        }

        public ProdutosXVenda(int id, int produtoId, int vendaId, decimal precoProduto, decimal quantidadeProduto, DateTime dataInclusao) : base(id, dataInclusao)
        {
            Validate(produtoId, vendaId, precoProduto, quantidadeProduto);

            ProdutoId = produtoId;
            VendaId = vendaId;
            PrecoProduto = precoProduto;
            QuantidadeProduto = quantidadeProduto;
        }

        private void Validate(int produtoId, int vendaId, decimal precoProduto, decimal quantidadeProduto)
        {
            DomainExceptionValidate.When(produtoId <= 0, "Identificador do produto inválido.");
            DomainExceptionValidate.When(vendaId <= 0, "Identificador da venda inválido.");
            DomainExceptionValidate.When(precoProduto <= 0, "Preço do produto inválido. Deve ser maior do que 0");
            DomainExceptionValidate.When(quantidadeProduto <= 0, "Quantidade do produto inválido. Deve ser maior do que 0");
        }
    }
}
