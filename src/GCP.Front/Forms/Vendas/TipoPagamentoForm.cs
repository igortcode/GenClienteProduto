﻿using GCP.App.DTO.Venda;
using GCP.App.Interfaces.Services;
using GCP.Core.Enums;

namespace GCP.Front.Forms.Vendas
{
    public partial class TipoPagamentoForm : Form
    {
        private readonly IVendaServices _vendaServices;
        private readonly VendaForm _vendaForm;
        private readonly VendaDTO _vendaDTO;

        public TipoPagamentoForm(IVendaServices vendaServices, VendaForm vendaForm, VendaDTO vendaDTO)
        {
            _vendaServices = vendaServices;
            _vendaForm = vendaForm;
            _vendaDTO = vendaDTO;

            InitializeComponent();
            cbTipoPagamento.Items.Add("Dinheiro");
            cbTipoPagamento.Items.Add("Debito");
            cbTipoPagamento.Items.Add("Credito");
            cbTipoPagamento.Items.Add("Cheque");
            cbTipoPagamento.SelectedIndex = 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                var result = cbTipoPagamento.SelectedItem.ToString();

                _vendaDTO.TipoPagamento = (TipoPagamento)Enum.Parse(typeof(TipoPagamento), result);

                _vendaServices.Add(_vendaDTO);
                MessageBox.Show("Venda cadastrada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _vendaForm.LimparDados();
                Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível processar a venda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
