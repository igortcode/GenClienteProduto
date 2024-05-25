using AutoMapper;
using GCP.App.DTO.Produtos;
using GCP.Core.Entities;

namespace GCP.App.Profiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ProdutoDTO, Produto>();
        }
    }
}
