using GCP.App.DTO.Clientes;
using GCP.App.Interfaces.Services;
using GCP.Core.Validations.CustomExceptions;

namespace GCP.Front.Forms
{
    public partial class ClientForm : Form
    {
        private readonly IClienteServices _clienteServices;
        private int _id;
        private EnderecoDTO _endereco;

        public ClientForm(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
            InitializeComponent();
            DataBind();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidateFieldsCad())
            {
                try
                {
                    var cliente = CastFormCadToDto();

                    _clienteServices.Add(cliente);

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
             "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var cliente = CastFormAltToDto();

                        _clienteServices.Add(cliente);

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
            if (dtGridCliente.CurrentRow.Cells[0].Value != null)
            {
                (tabEdit as Control).Enabled = true;

                var id = (int)dtGridCliente.CurrentRow.Cells[0].Value;

                _id = id;

                PreencherAlterar(_clienteServices.GetById(id));

                tabControlProduto.SelectedTab = tabEdit;
            }
        }

        private void PreencherAlterar(ClienteDTO cliente)
        {
            txtNomeAlt.Text = cliente.Nome;
            mkCpfAlt.Text = cliente.Cpf;
            mkTelefoneAlt.Text = cliente.Telefone;
            txtEmailAlt.Text = cliente.Email;
            _endereco = cliente.Endereco;
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
                    _clienteServices.Remove(_id);

                    MessageBox.Show("Registro excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxAlt();
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
            if (dtGridCliente.CurrentRow.Cells[0].Value != null)
            {
                (tabEdit as Control).Enabled = true;

                var id = (int)dtGridCliente.CurrentRow.Cells[0].Value;

                _id = id;

                PreencherAlterar(_clienteServices.GetById(id));

                tabControlProduto.SelectedTab = tabEdit;
            }
            else
            {
                MessageBox.Show("Selecione uma linha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            var pesquisa = txtPesquisa.Text;

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                DataBind(null);
                return;
            }

            var result = _clienteServices.Search(pesquisa);
            DataBind(result.ToList());
        }


        private bool ValidateFieldsAlt()
        {
            if (string.IsNullOrWhiteSpace(txtNomeAlt.Text))
            {
                MessageBox.Show("Campo nome obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeAlt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(mkCpfAlt.Text))
            {
                MessageBox.Show("Campo Cpf obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mkCpfAlt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(mkTelefoneAlt.Text))
            {
                MessageBox.Show("Campo Telefone obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mkTelefoneAlt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailAlt.Text))
            {
                MessageBox.Show("Campo Email obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAlt.Focus();
                return false;
            }

            if (_endereco is null)
            {
                MessageBox.Show("Endereço obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullEnderecoAlt.Focus();
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

            if (string.IsNullOrWhiteSpace(mkCpf.Text))
            {
                MessageBox.Show("Campo Cpf obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mkCpf.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(mkTelefone.Text))
            {
                MessageBox.Show("Campo Telefone obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mkTelefone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Campo Email obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (_endereco is null)
            {
                MessageBox.Show("Endereço obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullEndereco.Focus();
                return false;
            }

            return true;
        }

        private void GoToList()
        {
            DataBind();
            tabControlProduto.SelectedTab = tabList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ClearTextBox()
        {
            txtNome.Text = string.Empty;
            mkCpf.Text = string.Empty;
            mkTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            _endereco = null;
        }

        private void ClearTextBoxAlt()
        {
            txtNomeAlt.Text = string.Empty;
            mkCpfAlt.Text = string.Empty;
            txtEmailAlt.Text = string.Empty;
            mkTelefoneAlt.Text = string.Empty;
            _endereco = null;
            _id = 0;

            cBAlterar.Checked = false;
            gbAlterar.Enabled = false;
            (tabEdit as Control).Enabled = false;
        }

        private ClienteDTO CastFormCadToDto()
        {
            var dto = new ClienteDTO
            {
                Nome = txtNome.Text,
                Cpf = mkCpf.Text,
                Email = txtEmail.Text,
                Telefone = mkTelefone.Text,
                Endereco = _endereco
            };

            return dto;
        }

        private ClienteDTO CastFormAltToDto()
        {
            var dto = new ClienteDTO
            {
                Id = _id,
                Nome = txtNomeAlt.Text,
                Cpf = mkCpfAlt.Text,
                Email = txtEmailAlt.Text,
                Telefone = mkTelefoneAlt.Text,
                Endereco = _endereco
            };

            return dto;
        }

        private bool ValidaDecimal(string text)
        {
            return decimal.TryParse(text, out var valor);
        }
        private void DataBind(IList<ClienteDTO>? clientes = null)
        {
            if (clientes is null)
                clientes = _clienteServices.GetAll().ToList();

            dtGridCliente.Rows.Clear();
            dtGridCliente.Columns.Clear();
            dtGridCliente.Refresh();

            dtGridCliente.Columns.Add("Id", "Id");
            dtGridCliente.Columns.Add("Nome", "Nome");
            dtGridCliente.Columns.Add("Email", "Email");
            dtGridCliente.Columns.Add("Cpf", "Cpf");
            dtGridCliente.Columns.Add("Telefone", "Telefone");

            dtGridCliente.Columns[0].Visible = false;
            dtGridCliente.Columns[1].Width = 200;
            dtGridCliente.Columns[2].Width = 200;
            dtGridCliente.Columns[3].Width = 100;
            dtGridCliente.Columns[4].Width = 200;

            if (clientes.Count() < 1)
            {
                dtGridCliente.Rows.Add(1);
            }
            else
            {
                dtGridCliente.Rows.Add(clientes.Count);

                for (int i = 0; i < clientes.Count; i++)
                {
                    dtGridCliente.Rows[i].Cells[0].Value = clientes[i].Id;
                    dtGridCliente.Rows[i].Cells[1].Value = clientes[i].Nome;
                    dtGridCliente.Rows[i].Cells[2].Value = clientes[i].Email;
                    dtGridCliente.Rows[i].Cells[3].Value = clientes[i].Cpf;
                    dtGridCliente.Rows[i].Cells[4].Value = clientes[i].Telefone;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            if(_endereco is null)
                _endereco = new EnderecoDTO();

            var enderecoFrom = new EnderecoForm(ref _endereco);
            enderecoFrom.ShowDialog();
        }
    }
}
