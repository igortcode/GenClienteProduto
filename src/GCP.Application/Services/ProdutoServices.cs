using AutoMapper;
using GCP.App.DTO.Produtos;
using GCP.App.Interfaces.Repository;
using GCP.App.Interfaces.Services;
using GCP.Core.Entities;
using GCP.Core.Validations.CustomExceptions;

namespace GCP.App.Services
{
    public class ProdutoServices : IProdutoServices
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoServices(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public void Add(ProdutoDTO dto)
        {
            if (_produtoRepository.ExistByCode(dto.Codigo))
                throw new DomainExceptionValidate("Código já existe para outro produto.");

            var result = _mapper.Map<Produto>(dto);


            _produtoRepository.Add(result);          
        }
    }
}
