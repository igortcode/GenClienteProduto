using GCP.Core.ValuableObjects;

namespace GCP.App.DTO.Clientes
{
    public class EnderecoDTO
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }


        public EnderecoDTO()
        {
            
        }
        public EnderecoDTO(EnderecoVO enderecoVO)
        {
            Cep = enderecoVO.Cep;
            Logradouro = enderecoVO.Logradouro;
            Bairro = enderecoVO.Bairro;
            Cidade = enderecoVO.Cidade;
            Estado = enderecoVO.Estado;
            Numero = enderecoVO.Numero;
            Complemento = enderecoVO.Complemento;
        }

        public EnderecoVO CastToEnderecoVO()
        {
            return new EnderecoVO(Cep, Logradouro, Bairro, Cidade, Estado, Numero, Complemento);
        }

        public string EnderecoCompleto()
        {
            return $"{Logradouro}-{Numero}/{Bairro}/{Cidade}-{Estado}/{Cep}";
        }


    }
}
