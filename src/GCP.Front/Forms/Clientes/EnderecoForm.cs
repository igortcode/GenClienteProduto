using GCP.App.DTO.Clientes;
using GCP.App.DTO.ViaCep;
using System.Data;
using System.Net.Http.Json;

namespace GCP.Front.Forms
{
    public partial class EnderecoForm : Form
    {
        private static IReadOnlyDictionary<string, string> StatesFromBrazil = new Dictionary<string, string>
        {
            {"AC", "Acre"},
            {"AL", "Alagoas"},
            {"AP", "Amapá"},
            {"AM", "Amazonas"},
            {"BA", "Bahia"},
            {"CE", "Ceara"},
            {"DF", "Distrito Federal"},
            {"ES", "Espirito Santo"},
            {"GO", "Goiás"},
            {"MA", "Maranhão"},
            {"MT", "Mato Grosso"},
            {"MS", "Mato Grosso do Sul"},
            {"MG", "Minas Gerais"},
            {"PA", "Para"},
            {"PB", "Paraíba"},
            {"PR", "Paraná"},
            {"PE", "Pernambuco"},
            {"PI", "Piauí"},
            {"RJ", "Rio de Janeiro"},
            {"RN", "Rio Grande do Norte"},
            {"RS", "Rio Grande do Sul"},
            {"RO", "Rondônia"},
            {"RR", "Roraima"},
            {"SC", "Santa Catarina"},
            {"SP", "São Paulo"},
            {"SE", "Sergipe"},
            {"TO", "Tocantins"},
        };
        private EnderecoDTO _endereco;
        private readonly TextBox _txtEndereco;

        public EnderecoForm(EnderecoDTO endereco, TextBox txtEndereco)
        {
            _endereco = endereco;
            _txtEndereco = txtEndereco;
            InitializeComponent();
            InicializaDados();

        }

        private void InicializaDados()
        {
            cbEstado.Items.AddRange(StatesFromBrazil.Select(a => a.Key).ToArray());
            pbLoading.Visible = false;
           
            if (!string.IsNullOrWhiteSpace(_endereco.Cep))
            {
                PreencheEndereco(_endereco);
            }
        }

        private void mkCep_KeyUp(object sender, KeyEventArgs e)
        {
            if (mkCep.Text.Length == 10 && string.IsNullOrWhiteSpace(_endereco.Cep))
            {
                BuscarEndereco();
            }
        }

        private void BuscarEndereco()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    pbLoading.Visible = true;

                    var result = httpClient.GetFromJsonAsync<ViaCepResult>($"https://viacep.com.br/ws/{mkCep.Text.Replace(".", "").Replace("-", "")}/json/").Result;

                    pbLoading.Visible = false;
                    if (string.IsNullOrEmpty(result.Cep))
                    {
                        mkCep.Text = string.Empty;
                        throw new ArgumentException("Insira um Cep válido");
                    }

                    PreencheEndereco(result);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao buscar o endereço! Insira um CEP válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void PreencheEndereco(ViaCepResult result)
        {
            txtLogradouro.Text = result.Logradouro;
            txtBairro.Text = result.Bairro;
            txtCidade.Text = result.Localidade;
            cbEstado.SelectedIndex = cbEstado.FindString(result.Uf);

            txtLogradouro.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            mkCep.Enabled = true;
            cbEstado.Enabled = true;
        }

        private void PreencheEndereco(EnderecoDTO result)
        {
            mkCep.Text = result.Cep;
            txtLogradouro.Text = result.Logradouro;
            txtBairro.Text = result.Bairro;
            txtCidade.Text = result.Cidade;
            cbEstado.SelectedIndex = cbEstado.FindString(result.Estado);
            txtComplemento.Text = result.Complemento;
            txtNumero.Text = result.Numero;

            txtLogradouro.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            mkCep.Enabled = true;
            cbEstado.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {

                _endereco.Cidade = txtCidade.Text;
                _endereco.Bairro = txtBairro.Text;
                _endereco.Cep = mkCep.Text;
                _endereco.Complemento = txtComplemento.Text;
                _endereco.Estado = cbEstado.SelectedItem?.ToString();
                _endereco.Logradouro = txtLogradouro.Text;
                _endereco.Numero = txtNumero.Text;

                _txtEndereco.Text = _endereco.EnderecoCompleto();

                LimparCampos();
                Dispose();
            }
        }

        private bool ValidaCampos()
        {
            if (string.IsNullOrWhiteSpace(txtLogradouro.Text))
            {
                MessageBox.Show("Campo Logradouro obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogradouro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Campo Bairro obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("Campo Cidade obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Campo Número obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(mkCep.Text))
            {
                MessageBox.Show("Campo Cep obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mkCep.Focus();
                return false;
            }

            return true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Dispose();
        }

        private void LimparCampos()
        {
            mkCep.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cbEstado.SelectedIndex = 1;
        }

        private void pbLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
