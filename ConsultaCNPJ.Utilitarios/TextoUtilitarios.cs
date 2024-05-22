namespace ConsultaCNPJ.Utilitarios
{
    public static class TextoUtilitarios
    {
        public static string TruncarTexto(this string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }

        public static string RemoverMascaraCNPJ(this string value)
        {
            return value.Replace(".", "").Replace("/", "").Replace("-", "");
        }
    }
}
