using GCP.Core.Validations.CustomExceptions;

namespace GCP.Core.Validations
{
    public static class ValidationsHelper
    {
        public static void StringValidate(string? conteudo, string? campo, int tamanhoMaximo)
        {
            DomainExceptionValidate.When(string.IsNullOrEmpty(conteudo), $"{campo} inválido. Não pode ser nulo ou vazio.");
            DomainExceptionValidate.When(conteudo?.Length > tamanhoMaximo, $"{campo} inválido. O campo deve conter no máximo {tamanhoMaximo} caracteres.");
        }

        public static void ValidateCPF(string conteudo, string? campo)
        {
            StringValidate(conteudo, campo, 14);
            DomainExceptionValidate.When(!ValidateCPF(conteudo), $"{campo} inválido.");
        }

        private static bool ValidateCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");
            
            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                  valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {

                if (numeros[9] != 0)

                    return false;

            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                    return false;

            return true;

        }
    }
}
