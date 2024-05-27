using GCP.Core.Entities.Generic;
using GCP.Core.Validations;
using GCP.Core.Validations.CustomExceptions;
using GCP.Core.ValuableObjects;

namespace GCP.Core.Entities
{
    public sealed class Cliente : Entity
    {
        public string? Nome { get; private set; }
        public string? Cpf { get; private set; }
        public EnderecoVO? Endereco { get; private set; }
        public string? Telefone { get; private set; }
        public string? Email { get; private set; }


        public Cliente(int id,  string nome, string cpf, string cep, string logradouro, string bairro, string cidade, string estado, string numero, string complemento, string telefone, string email, DateTime dataInclusao) : base(id, dataInclusao)
        {
            var endereco = new EnderecoVO(cep, logradouro, bairro, cidade, estado, numero, complemento);
            Validate(nome, cpf, endereco, telefone, email);

            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }

        public Cliente(string nome, string cpf, EnderecoVO? endereco, string telefone, string email)
        {
            Validate(nome, cpf, endereco, telefone, email);

            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }

        public void Atualizar(string nome, string cpf, EnderecoVO? endereco, string telefone, string email)
        {
            Validate(nome, cpf, endereco, telefone, email);

            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
        }

        private void Validate(string? nome, string cpf, EnderecoVO? endereco, string? telefone, string? email)
        {
            ValidationsHelper.StringValidate(nome, "Nome", 300);
            ValidationsHelper.StringValidate(telefone, "Telefone", 20);
            ValidationsHelper.StringValidate(email, "Email", 100);
            ValidationsHelper.ValidateCPF(cpf, "Cpf");
            DomainExceptionValidate.When(endereco is null, "Endereço inválido. Não pode ser nulo.");
        }
    }
}
