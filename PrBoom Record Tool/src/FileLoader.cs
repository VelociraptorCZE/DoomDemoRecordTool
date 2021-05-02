namespace PrBoomRecordTool
{
    class FileLoader
    {
        private readonly App app;

        public FileLoader(App app) 
        {
            this.app = app;
        }

        public void LoadPrBoom()
        {
            string path = app.openPrBoomDialog.FileName;
            app.prBoomPathLabel.Text = path;
            SaveConfig("PrBoomPath", path);
        }

        public void LoadIwad()
        {
            string path = app.openIwadDialog.FileName;
            app.iwadPathLabel.Text = path;
            SaveConfig("IwadPath", path);
        }

        private void SaveConfig(string key, string value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }
    }
}
