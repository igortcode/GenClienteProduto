using GCP.Core.Enums;

namespace GCP.App.Helpers
{
    public static class GetEnums
    {
        public static TipoPagamento? GetTipoPagamento(string tipoPagamento)
        {
            return tipoPagamento switch
            {
                "Debito" => TipoPagamento.Debito,
                "Débito" => TipoPagamento.Debito,
                "Credito" => TipoPagamento.Credito,
                "Crédito" => TipoPagamento.Credito,
                "Cheque" => TipoPagamento.Cheque,
                "Dinheiro" => TipoPagamento.Dinheiro,
                _ => null
            };
        }

        public static string GetTipoPagamentoName(TipoPagamento tipoPagamento)
        {
            return tipoPagamento switch
            {
                TipoPagamento.Debito => "Débito",
                TipoPagamento.Credito => "Crédito",
                TipoPagamento.Dinheiro => "Dinheiro",
                TipoPagamento.Cheque => "Cheque"
            };
        }
    }
}
