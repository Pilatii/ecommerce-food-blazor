namespace Cardapio.Utils
{
    public static class StringUtils
    {
        public static string OnlyNumbers(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var result = new char[input.Length];
            int pos = 0;

            foreach (char c in input)
            {
                if (c >= '0' && c <= '9') // comparação direta com chars
                {
                    result[pos++] = c;
                }
            }

            return new string(result, 0, pos);
        }
    }
}
