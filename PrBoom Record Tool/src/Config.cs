namespace PrBoomRecordTool
{
    static class Config
    {
        public static void Save(string key, string value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }

        public static string GetPrBoomPath()
        {
            return Properties.Settings.Default.PrBoomPath;
        }

        public static string GetIwadPath()
        {
            return Properties.Settings.Default.IwadPath;
        }

        public static string GetLastDemoName()
        {
            return Properties.Settings.Default.LastDemoName;
        }
    }
}
