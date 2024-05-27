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

        public EnderecoForm(ref EnderecoDTO endereco)
        {
            _endereco = endereco;
            InitializeComponent();
            InicializaDados();
        }

        private void InicializaDados()
        {
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
                cbEstado.Items.AddRange(StatesFromBrazil.Select(a => a.Key).ToArray());
            }
        }

        private void BuscarEndereco()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var result = httpClient.GetFromJsonAsync<ViaCepResult>($"https://viacep.com.br/ws/{mkCep.Text.Replace(".", "").Replace("-", "")}/json/").Result;

                    PreencheEndereco(result);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao buscar o endereço! Insira um CEP válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void PreencheEndereco(ViaCepResult? result)
        {
            txtLogradouro.Text = result.Logradouro;
            txtBairro.Text = result.Bairro;
            txtCidade.Text = result.Localidade;
            cbEstado.SelectedIndex = cbEstado.FindString(result.Uf);
        }

        private void PreencheEndereco(EnderecoDTO? result)
        {
            mkCep.Text = result.Cep;
            txtLogradouro.Text = result.Logradouro;
            txtBairro.Text = result.Bairro;
            txtCidade.Text = result.Cidade;
            cbEstado.SelectedIndex = cbEstado.FindStringExact(result.Estado);
            txtComplemento.Text = result.Complemento;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                _endereco = new EnderecoDTO
                {
                    Cidade = txtCidade.Text,
                    Bairro = txtBairro.Text,
                    Cep = txtCidade.Text,
                    Complemento = txtComplemento.Text,
                    Estado = cbEstado.SelectedText,
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                };

                LimparCampos();
                this.Close();
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
            this.Close();
        }

        private void LimparCampos()
        {
            mkCep.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtNumero.Text = string.Empty;  
            txtBairro.Text = string.Empty;
            cbEstado.SelectedIndex = 0;
        }
    }
}
