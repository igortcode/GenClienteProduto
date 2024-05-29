using GCP.App.DTO.Produtos;
using GCP.App.Interfaces.Services;
using GCP.Core.Validations.CustomExceptions;


namespace GCP.Front.Forms
{
    public partial class ProdutoForm : Form
    {
        private IProdutoServices _produtoServices;
        private int _id;

        public ProdutoForm(IProdutoServices produtoServices)
        {
            _produtoServices = produtoServices;
            InitializeComponent();
            DataBind();
            (tabEdit as Control).Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidateFieldsCad())
            {
                try
                {
                    var produtoDto = CastFormCadToDto();

                    _produtoServices.Add(produtoDto);

                    MessageBox.Show("Cadastro efetuado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ClearTextBox();
                    GoToList();
                }
                catch (DomainExceptionValidate dev)
                {
                    MessageBox.Show("Não foi possível inserir o registro. Mensagem: " + dev.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ops! Aconteceu algum problema. Verifique a conexão com o banco de dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVotarCad_Click(object sender, EventArgs e)
        {
            tabControlProduto.SelectedTab = tabList;
        }

        private void btnVoltarEdit_Click(object sender, EventArgs e)
        {
            ClearTextBoxAlt();
            tabControlProduto.SelectedTab = tabList;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateFieldsAlt())
            {
                var result = MessageBox.Show("Tem certeza que deseja alterar esse registro?",
             "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var produto = CastFormAltToDto();

                        _produtoServices.Update(produto);
                        MessageBox.Show("Registro atualizado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearTextBoxAlt();
                        GoToList();
                    }
                    catch (DomainExceptionValidate dev)
                    {
                        MessageBox.Show("Não foi possível inserir o registro. Mensagem: " + dev.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ops! Aconteceu algum problema. Verifique a conexão com o banco de dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void cBAlterar_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAlterar.Checked)
            {
                gbAlterar.Enabled = true;
            }
            else
            {
                gbAlterar.Enabled = false;
            }
        }

        private void dtGridProduto_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void dtGridProduto_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtGridProduto.CurrentRow.Cells[0].Value != null)
                {
                    (tabEdit as Control).Enabled = true;

                    var id = (int)dtGridProduto.CurrentRow.Cells[0].Value;

                    _id = id;

                    PreencherAlterar(_produtoServices.GetById(id));

                    tabControlProduto.SelectedTab = tabEdit;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherAlterar(ProdutoDTO produtoDTO)
        {
            txtNomeAlt.Text = produtoDTO.Nome;
            txtCodigoAlt.Text = produtoDTO.Codigo;
            txtDescAlt.Text = produtoDTO.Descricao;
            txtPrecoAltNu.Value = produtoDTO.Preco;
            txtQtdNuAlt.Value = produtoDTO.Quantidade;
        }

        private void btnIrCadastrar_Click(object sender, EventArgs e)
        {
            tabControlProduto.SelectedTab = tabAdd;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja excluir esse registro?",
             "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _produtoServices.Remove(_id);

                    MessageBox.Show("Registro excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxAlt();
                    DataBind();
                    tabControlProduto.SelectedTab = tabList;
                    (tabEdit as Control).Enabled = false;
                }
                catch (DomainExceptionValidate dev)
                {
                    MessageBox.Show("Não foi possível inserir o registro. Mensagem: " + dev.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ops! Aconteceu algum problema. Verifique a conexão com o banco de dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAtualizarList_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGridProduto.CurrentRow.Cells[0].Value != null)
                {
                    (tabEdit as Control).Enabled = true;

                    var id = (int)dtGridProduto.CurrentRow.Cells[0].Value;

                    _id = id;

                    PreencherAlterar(_produtoServices.GetById(id));

                    tabControlProduto.SelectedTab = tabEdit;
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
                    DataBind(null);
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


        private bool ValidateFieldsAlt()
        {
            if (string.IsNullOrWhiteSpace(txtNomeAlt.Text))
            {
                MessageBox.Show("Campo nome obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeAlt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoAlt.Text))
            {
                MessageBox.Show("Campo código obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoAlt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecoAltNu.Text) && !ValidaDecimal(txtPrecoNu.Text))
            {
                MessageBox.Show("Campo preço deve ser maior do que 0!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecoAltNu.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQtdNuAlt.Text) && !ValidaDecimal(txtQtdNu.Text))
            {
                MessageBox.Show("Campo quantidade deve ser maior do que 0!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdNuAlt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescAlt.Text))
            {
                MessageBox.Show("Campo descrição obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescAlt.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateFieldsCad()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Campo nome obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Campo código obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecoNu.Text) && !ValidaDecimal(txtPrecoNu.Text))
            {
                MessageBox.Show("Campo preço deve ser maior do que 0!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecoNu.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQtdNu.Text) && !ValidaDecimal(txtQtdNu.Text))
            {
                MessageBox.Show("Campo quantidade deve ser maior do que 0!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdNu.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Campo descrição obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesc.Focus();
                return false;
            }

            return true;
        }

        private void GoToList()
        {
            DataBind();
            tabControlProduto.SelectedTab = tabList;
        }

        private void ClearTextBox()
        {
            txtNome.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtPrecoNu.Value = 0;
            txtQtdNu.Value = 0;
        }

        private void ClearTextBoxAlt()
        {
            txtNomeAlt.Text = string.Empty;
            txtCodigoAlt.Text = string.Empty;
            txtDescAlt.Text = string.Empty;
            txtPrecoAltNu.Value = 0;
            txtQtdNuAlt.Value = 0;
            _id = 0;

            cBAlterar.Checked = false;
            gbAlterar.Enabled = false;
            (tabEdit as Control).Enabled = false;
        }

        private ProdutoDTO CastFormCadToDto()
        {
            var dto = new ProdutoDTO
            {
                Nome = txtNome.Text,
                Codigo = txtCodigo.Text,
                Preco = txtPrecoNu.Value,
                Quantidade = txtQtdNu.Value,
                Descricao = txtDesc.Text
            };

            return dto;
        }

        private ProdutoDTO CastFormAltToDto()
        {
            var dto = new ProdutoDTO
            {
                Id = _id,
                Nome = txtNomeAlt.Text,
                Codigo = txtCodigoAlt.Text,
                Preco = txtPrecoAltNu.Value,
                Quantidade = txtQtdNuAlt.Value,
                Descricao = txtDescAlt.Text
            };

            return dto;
        }

        private bool ValidaDecimal(string text)
        {
            return decimal.TryParse(text, out var valor);
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
    }
}
