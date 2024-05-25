using GCP.Core.Entities.Generic;
using GCP.Core.Validations;
using GCP.Core.Validations.CustomExceptions;

namespace GCP.Core.Entities
{
    public sealed class Produto : Entity
    {
        public string? Nome { get; private set; }
        public string? Codigo { get; private set; }
        public string? Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public decimal Quantidade { get; private set; }

        public Produto(string nome, string codigo, string descricao, decimal preco, decimal quantidade)
        {
            Validate(nome, codigo, descricao, preco, quantidade);

            Nome = nome;
            Codigo = codigo;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(int id, string nome, string codigo, string descricao, decimal preco, decimal quantidade, DateTime dataInclusao) : base(id, dataInclusao)
        {
            Validate(nome, codigo, descricao, preco, quantidade);

            Nome = nome;
            Codigo = codigo;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void Atualizar(string nome, string codigo, string descricao, decimal preco, decimal quantidade)
        {
            Validate(nome, codigo, descricao, preco, quantidade);

            Nome = nome;
            Codigo = codigo;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void EfetuarRetirada(decimal quantidade)
        {
            if (quantidade > Quantidade)
                throw new DomainExceptionValidate("Quantidade inválida. Valor de retirada é maior do que o valor do estoque.");

            Quantidade -= quantidade;
        }

        private void Validate(string nome, string codigo, string descricao, decimal preco, decimal quantidade)
        {
            ValidationsHelper.StringValidate(nome, "Nome", 200);
            ValidationsHelper.StringValidate(codigo, "Código", 200);
            ValidationsHelper.StringValidate(descricao, "Descrição", 1000);
            DomainExceptionValidate.When(preco <= 0, "Preço inválido. Deve ser maior ou igual a zero.");
            DomainExceptionValidate.When(quantidade <= 0, "Quantidade inválida. Deve ser maior ou igual a zero.");
        }
    }
}
