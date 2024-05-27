using AutoMapper;
using GCP.App.DTO.Clientes;
using GCP.App.Interfaces.Repository;
using GCP.App.Interfaces.Services;
using GCP.Core.Entities;
using GCP.Core.Validations.CustomExceptions;

namespace GCP.App.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteServices(IClienteRepository clienteRepository, IMapper mapper) 
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public void Add(ClienteDTO dto)
        {
            if (_clienteRepository.ExistePorCpf(dto.Cpf))
                throw new DomainExceptionValidate("Já existe um cliente com esse CPF!");

            var cliente = _mapper.Map<Cliente>(dto);

            _clienteRepository.Add(cliente);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
           var entities = _clienteRepository.GetAll();

            return _mapper.Map<IEnumerable<ClienteDTO>>(entities);
        }

        public ClienteDTO GetByCpf(string cpf)
        {
            var entity = _clienteRepository.GetByCpf(cpf);

            return _mapper.Map<ClienteDTO>(entity);
        }

        public ClienteDTO GetById(int id)
        {
            var entity = _clienteRepository.GetById(id);

            return _mapper.Map<ClienteDTO>(entity);
        }

        public void Remove(int id)
        {
           _clienteRepository.Remove(id);
        }

        public IEnumerable<ClienteDTO> Search(string search)
        {
            var entities = _clienteRepository.Search(search);

            return _mapper.Map<IEnumerable<ClienteDTO>>(entities);
        }

        public void Update(ClienteDTO dto)
        {
            if (!dto.Id.HasValue || dto.Id == 0)
                throw new InvalidOperationException("Identificador inválido!");

            var entity = _clienteRepository.GetById(dto.Id.Value);

            if (_clienteRepository.ExistePorCpf(dto.Cpf) && entity.Cpf != dto.Cpf)
                throw new DomainExceptionValidate("Já existe um cliente com esse CPF!");

            entity.Atualizar(dto.Nome, dto.Cpf, dto.Endereco.CastToEnderecoVO(), dto.Telefone, dto.Email);

            _clienteRepository.Update(entity);
        }
    }
}
