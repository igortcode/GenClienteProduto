using GCP.App.DTO.Produtos;
using GCP.App.DTO.Venda;
using GCP.App.Interfaces.Services;
using GCP.Core.Validations.CustomExceptions;

namespace GCP.Front.Forms.Vendas
{
    public partial class ProdutoVendaForm : Form
    {
        private readonly IProdutoServices _produtoServices;
        private readonly IList<ProdutoXVendaDTO> _dtos;
        private int? _id;
        private VendaForm _chamador;

        public ProdutoVendaForm(IProdutoServices produtoServices, IList<ProdutoXVendaDTO> dtos, VendaForm chamador)
        {
            _produtoServices = produtoServices;
            _dtos = dtos;
            InitializeComponent();
            DataBind();
            _chamador = chamador;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaProduto();
        }

        private void dtGridProduto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtGridProduto.CurrentRow.Cells[0].Value != null)
                {


                    var id = (int)dtGridProduto.CurrentRow.Cells[0].Value;

                    _id = id;

                    var produto = _produtoServices.GetById(id);

                    txtNmProduto.Text = produto.Codigo + "-" + produto.Nome;
                    nUPreco.Value = produto.Preco;
                }
                else
                {
                    MessageBox.Show("Selecione uma linha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                var pesquisa = txtPesquisa.Text;

                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    DataBind();
                    return;
                }

                var result = _produtoServices.Search(pesquisa);
                DataBind(result.ToList());
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível buscar os produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataBind(IList<ProdutoDTO> produtos = null)
        {
            try
            {
                if (produtos is null)
                    produtos = _produtoServices.GetAll().ToList();

                dtGridProduto.Rows.Clear();
                dtGridProduto.Columns.Clear();
                dtGridProduto.Refresh();

                dtGridProduto.Columns.Add("Id", "Id");
                dtGridProduto.Columns.Add("Nome", "Nome");
                dtGridProduto.Columns.Add("Codigo", "Código");
                dtGridProduto.Columns.Add("Preco", "Preço");
                dtGridProduto.Columns.Add("Qtd", "Quantidade");
                dtGridProduto.Columns.Add("Descricao", "Descrição");

                dtGridProduto.Columns[0].Visible = false;
                dtGridProduto.Columns[1].Width = 200;
                dtGridProduto.Columns[2].Width = 200;
                dtGridProduto.Columns[3].Width = 100;
                dtGridProduto.Columns[4].Width = 100;
                dtGridProduto.Columns[5].Width = 500;

                if (produtos.Count() < 1)
                {
                    dtGridProduto.Rows.Add(1);
                }
                else
                {
                    dtGridProduto.Rows.Add(produtos.Count);

                    for (int i = 0; i < produtos.Count; i++)
                    {
                        dtGridProduto.Rows[i].Cells[0].Value = produtos[i].Id;
                        dtGridProduto.Rows[i].Cells[1].Value = produtos[i].Nome;
                        dtGridProduto.Rows[i].Cells[2].Value = produtos[i].Codigo;
                        dtGridProduto.Rows[i].Cells[3].Value = produtos[i].Preco;
                        dtGridProduto.Rows[i].Cells[4].Value = produtos[i].Quantidade;
                        dtGridProduto.Rows[i].Cells[5].Value = produtos[i].Descricao;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível buscar os produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dtGridProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dtGridProduto.CurrentRow.Cells[0].Value != null)
                {


                    var id = (int)dtGridProduto.CurrentRow.Cells[0].Value;

                    _id = id;

                    var produto = _produtoServices.GetById(id);

                    txtNmProduto.Text = produto.Codigo + "-" + produto.Nome;
                    nUPreco.Value = produto.Preco;
                }
                else
                {
                    MessageBox.Show("Selecione uma linha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var pesquisa = txtPesquisa.Text;

                    if (string.IsNullOrWhiteSpace(pesquisa))
                    {
                        DataBind();
                        return;
                    }

                    var result = _produtoServices.Search(pesquisa);
                    DataBind(result.ToList());
                }
                catch (Exception)
                {

                    MessageBox.Show("Não foi possível buscar os produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSelecionar_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SelecionaProduto();
            }
        }

        private void SelecionaProduto()
        {
            try
            {
                if (_id.HasValue)
                {
                    if (nUQtd.Value > 0)
                    {
                        var produto = _produtoServices.GetById(_id.Value);

                        if (_dtos.Any(a => a.ProdutoId == _id.Value))
                        {
                            var dto = _dtos.First(a => a.ProdutoId == _id);

                            var qtdTotal = dto.Quantidade + nUQtd.Value;
                            if (qtdTotal > produto.Quantidade)
                                throw new DomainExceptionValidate("Quantidade superior ao estoque deste produto! Selecione uma quantidade inferior!");

                            dto.Quantidade = qtdTotal;
                        }
                        else
                        {
                            if (nUQtd.Value > produto.Quantidade)
                                throw new DomainExceptionValidate("Quantidade superior ao estoque deste produto! Selecione uma quantidade inferior!");

                            _dtos.Add(new ProdutoXVendaDTO
                            {
                                ProdutoId = _id.Value,
                                Codigo = produto.Codigo,
                                Nome = produto.Nome,
                                Preco = produto.Preco,
                                Quantidade = nUQtd.Value,
                            });
                        }

                        _chamador.DataBind();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Quantidade selecionada deve ser maior do que 0.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (DomainExceptionValidate dev)
            {
                MessageBox.Show(dev.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
