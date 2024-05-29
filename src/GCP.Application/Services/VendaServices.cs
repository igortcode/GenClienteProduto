using GCP.App.DTO.Venda;
using GCP.App.Interfaces.Repository;
using GCP.App.Interfaces.Services;
using GCP.Core.Entities;
using System.Transactions;

namespace GCP.App.Services
{
    public class VendaServices : IVendaServices
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutosXVendaRepository _produtosXVendaRepository;

        public VendaServices(IVendaRepository vendaRepository, IProdutoRepository produtoRepository, IProdutosXVendaRepository produtosXVendaRepository)
        {
            _vendaRepository = vendaRepository;
            _produtoRepository = produtoRepository;
            _produtosXVendaRepository = produtosXVendaRepository;
        }

        public void Add(VendaDTO dto)
        {

            ValidaDadosEntrada(dto);

            var venda = new Venda(dto.ClienteDTO.Id.Value, dto.Produtos.Sum(a => (a.Preco * a.Quantidade)), dto.TipoPagamento);

            int idVenda = _vendaRepository.Add(venda);

            var produtosVenda = dto.Produtos.Select(a => new ProdutosXVenda(a.ProdutoId, idVenda, a.Preco, a.Quantidade));

            foreach (var produto in produtosVenda)
            {
                var entity = _produtoRepository.GetById(produto.ProdutoId);

                entity.EfetuarRetirada(produto.QuantidadeProduto);

                _produtoRepository.Update(entity);
            }

            _produtosXVendaRepository.AddRange(produtosVenda);
        }

        private void ValidaDadosEntrada(VendaDTO dto)
        {
            if (dto == null) throw new ArgumentNullException("Entada de dados inválida!");

            if (dto.ClienteDTO == null) throw new ArgumentNullException("Cliente informado é inválido!");

            if (dto.Produtos == null || dto.Produtos.Count == 0) throw new ArgumentNullException("Selecione ao menos um produto para a venda!");
        }

        public IEnumerable<VendaDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public VendaDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
