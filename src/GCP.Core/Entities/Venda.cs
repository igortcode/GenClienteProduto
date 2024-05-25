using GCP.Core.Entities.Generic;
using GCP.Core.Enums;
using GCP.Core.Validations.CustomExceptions;

namespace GCP.Core.Entities
{
    public sealed class Venda : Entity
    {
        public int ClienteId { get; private set; }
        public decimal ValorTotal { get; private set; }
        public TipoPagamento TipoPagamento { get; private set; }

        public Venda(int clienteId, decimal valorTotal, TipoPagamento tipoPagamento)
        {
            Validate(clienteId, valorTotal);
            ClienteId = clienteId;
            ValorTotal = valorTotal;
            TipoPagamento = tipoPagamento;
        }

        public Venda(int id, int clienteId, decimal valorTotal, TipoPagamento tipoPagamento, DateTime dataInclusao) : base(id, dataInclusao)
        {
            Validate(clienteId, valorTotal);
            ClienteId = clienteId;
            ValorTotal = valorTotal;
            TipoPagamento = tipoPagamento;
        }

        private void Validate(int clienteId, decimal valorTotal)
        {
            DomainExceptionValidate.When(clienteId <= 0, "Identificador do cliente é inválido.");
            DomainExceptionValidate.When(valorTotal <= 0, "Valor total é inválido. Deve ser maior do que 0");
        }

        public void Atualizar(int clienteId, decimal valorTotal, TipoPagamento tipoPagamento)
        {
            Validate(clienteId, valorTotal);
            ClienteId = clienteId;
            ValorTotal = valorTotal;
            TipoPagamento = tipoPagamento;
        }
    }
}
