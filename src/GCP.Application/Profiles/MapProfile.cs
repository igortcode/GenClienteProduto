using AutoMapper;
using GCP.App.DTO.Clientes;
using GCP.App.DTO.Produtos;
using GCP.Core.Entities;

namespace GCP.App.Profiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ProdutoDTO, Produto>().ReverseMap();
            CreateMap<ClienteDTO, Cliente>()
                .ConstructUsing(a => new Cliente(a.Nome, a.Cpf, a.Endereco.CastToEnderecoVO(), a.Telefone, a.Email));
            CreateMap<Cliente, ClienteDTO>()
                .ForMember(a => a.Endereco, op => op.MapFrom(a => new EnderecoDTO(a.Endereco)));
        }
    }
}
