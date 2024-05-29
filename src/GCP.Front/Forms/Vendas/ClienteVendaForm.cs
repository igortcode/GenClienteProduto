using GCP.App.DTO.Clientes;
using GCP.App.Interfaces.Services;

namespace GCP.Front.Forms.Vendas
{
    public partial class ClienteVendaForm : Form
    {
        private readonly IClienteServices _clienteServices;
        private ClienteDTO _clienteDTO;
        private Label _lbNmCliente;
        private Label _lbEmail;
        private Label _lbEndereco;
        private GroupBox _gbVenda;
        private int _id;

        public ClienteVendaForm(IClienteServices clienteServices, ClienteDTO clienteDTO, Label lbNmCliente, Label lbEmail, Label lbEndereco, GroupBox gbVenda)
        {
            _clienteServices = clienteServices;
            _clienteDTO = clienteDTO;
            _lbNmCliente = lbNmCliente;
            _lbEmail = lbEmail;
            _lbEndereco = lbEndereco;
            _gbVenda = gbVenda; 

            InitializeComponent();

            DataBind();
        }

        private void dtGridCliente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtGridCliente.CurrentRow.Cells[0].Value != null)
                {

                    var id = (int)dtGridCliente.CurrentRow.Cells[0].Value;

                    _id = id;

                    var client = _clienteServices.GetById(id);

                    _clienteDTO.Nome = client.Nome;
                    _clienteDTO.Id = id;
                    _clienteDTO.Telefone = client.Telefone;
                    _clienteDTO.Cpf = client.Cpf;
                    _clienteDTO.Endereco = client.Endereco;
                    _clienteDTO.Email = client.Email;
                    _lbEmail.Text = client.Email;
                    _lbEndereco.Text = client.Endereco.EnderecoCompleto();
                    _lbNmCliente.Text = client.Nome;
                    _gbVenda.Enabled = true;


                    Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar buscar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var result = _clienteServices.Search(pesquisa);
                DataBind(result.ToList());
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar pesquisar os clientes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGridCliente.CurrentRow.Cells[0].Value != null)
                {

                    var id = (int)dtGridCliente.CurrentRow.Cells[0].Value;

                    _id = id;

                    var client = _clienteServices.GetById(id);

                    _clienteDTO.Nome = client.Nome;
                    _clienteDTO.Id = id;
                    _clienteDTO.Telefone = client.Telefone;
                    _clienteDTO.Cpf = client.Cpf;
                    _clienteDTO.Endereco = client.Endereco;
                    _clienteDTO.Email = client.Email;

                    _lbEmail.Text = client.Email;
                    _lbEndereco.Text = client.Endereco.EnderecoCompleto();
                    _lbNmCliente.Text = client.Nome;
                    _gbVenda.Enabled = true;

                    Dispose();
                }
                else
                {
                    MessageBox.Show("Selecione uma linha!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar buscar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DataBind(IList<ClienteDTO> clientes = null)
        {
            try
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

                dtGridCliente.Columns[0].Visible = false;
                dtGridCliente.Columns[1].Width = 250;
                dtGridCliente.Columns[2].Width = 200;
                dtGridCliente.Columns[3].Width = 120;

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
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao tentar buscar os clientes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
