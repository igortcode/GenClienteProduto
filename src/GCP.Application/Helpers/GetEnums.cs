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
    }
}
