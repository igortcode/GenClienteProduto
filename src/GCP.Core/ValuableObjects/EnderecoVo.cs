using GCP.Core.Validations;

namespace GCP.Core.ValuableObjects
{
    public class EnderecoVO
    {
        public string? Cep { get; private set; }
        public string? Logradouro { get; private set; }
        public string? Bairro { get; private set; }
        public string? Cidade { get; private set; }
        public string? Estado { get; private set; }
        public string? Numero { get; private set; }
        public string? Complemento { get; private set; }

        public EnderecoVO(string cep, string logradouro, string bairro, string cidade, string estado, string numero, string complemento)
        {
            Validate(cep, logradouro, bairro, cidade, estado, numero, complemento);

            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Numero = numero;
            Complemento = complemento;
        }

        public string EnderecoCompleto()
        {
            return $"{Logradouro} - Bairro: {Bairro} - Cidade: {Cidade}/{Estado} - Número: {Numero}";
        }

        private void Validate(string cep, string logradouro, string bairro, string cidade, string estado, string numero, string complemento)
        {
            ValidationsHelper.StringValidate(cep, "CEP", 10);
            ValidationsHelper.StringValidate(logradouro, "Logradouro", 400);
            ValidationsHelper.StringValidate(bairro, "Bairro", 300);
            ValidationsHelper.StringValidate(cidade, "Cidade", 300);
            ValidationsHelper.StringValidate(estado, "Estado", 2);
            ValidationsHelper.StringValidate(numero, "Número", 50);
        }
    }
}
