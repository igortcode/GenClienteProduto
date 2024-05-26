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

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var entities = _produtoRepository.GetAll();

            return _mapper.Map<IEnumerable<ProdutoDTO>>(entities);
        }

        public ProdutoDTO GetById(int id)
        {
            var entity = _produtoRepository.GetById(id);

            return _mapper.Map<ProdutoDTO>(entity);
        }

        public void Remove(int id)
        {
            _produtoRepository.Remove(id);
        }

        public IEnumerable<ProdutoDTO> Search(string search)
        {
            var entities = _produtoRepository.Search(search);

            return _mapper.Map<IEnumerable<ProdutoDTO>>(entities);
        }

        public void Update(ProdutoDTO dto)
        {
            if (!dto.Id.HasValue)
                throw new InvalidOperationException("Identificador inválido!");

            var entity = _produtoRepository.GetById(dto.Id.Value);

            if(_produtoRepository.ExistByCode(dto.Codigo) && entity?.Codigo != dto.Codigo)
                throw new DomainExceptionValidate("Código já existe para outro produto.");

            entity?.Atualizar(dto.Nome, dto.Codigo, dto.Descricao, dto.Preco, dto.Quantidade);

            _produtoRepository.Update(entity);

        }
    }
}
