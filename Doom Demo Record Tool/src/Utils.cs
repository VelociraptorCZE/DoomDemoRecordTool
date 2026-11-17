namespace DoomDemoRecordTool
{
    static class Utils
    {
        public static string TruncateText(string text, int maxLength)
        {
            if (text.Length <= maxLength)
            {
                return text;
            }

            return text.Substring(0, maxLength) + "…";
        }
    }
}
