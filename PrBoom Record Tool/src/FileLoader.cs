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
            Config.Save("PrBoomPath", path);
        }

        public void LoadIwad()
        {
            string path = app.openIwadDialog.FileName;
            app.iwadPathLabel.Text = path;
            Config.Save("IwadPath", path);
        }
    }
}
