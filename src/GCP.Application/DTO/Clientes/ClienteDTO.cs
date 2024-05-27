namespace GCP.App.DTO.Clientes
{
    public class ClienteDTO
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public EnderecoDTO? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}
