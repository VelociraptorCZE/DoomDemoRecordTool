namespace PrBoomRecordTool
{
    static class Config
    {
        public static void Save<T>(string key, T value)
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

        public static string[] GetPwads()
        {
            return Properties.Settings.Default.Pwads.Split('|');
        }

        public static bool HasIwadEpisodes()
        {
            return Properties.Settings.Default.HasIwadEpisodes;
        }

        public static bool IsFast()
        {
            return Properties.Settings.Default.IsFast;
        }

        public static bool IsNoMo()
        {
            return Properties.Settings.Default.IsNoMo;
        }

        public static bool IsRespawn()
        {
            return Properties.Settings.Default.IsRespawn;
        }

        public static int GetDifficulty()
        {
            return Properties.Settings.Default.Difficulty;
        }

        public static int GetEpisode()
        {
            return Properties.Settings.Default.Episode;
        }

        public static int GetLevel()
        {
            return Properties.Settings.Default.Level;
        }

        public static int GetComplevel()
        {
            return Properties.Settings.Default.Complevel;
        }
    }
}
