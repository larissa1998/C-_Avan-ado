namespace System
{
    public static class StringExtension
    {
        public static string FirstToUpper(this string str)
        {
            string first = str.Substring(0, 1);

            string second = str.Substring(1);

            return first.ToUpper() + second;
        }
    }
}
