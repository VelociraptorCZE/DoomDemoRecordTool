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

            string wad = GetCurrentWad();
            DecideComplevel(wad);
            app.isEpisodeActiveCheckbox.Checked = wad == "doom";
        }

        private string GetCurrentWad()
        {
            return app.openIwadDialog.SafeFileName.ToLower().Replace(".wad", "");
        }

        private void DecideComplevel(string wad)
        {
            if (wad == "doom")
            {
                app.complevelInput.Value = 3;
            }

            if (wad == "doom2")
            {
                app.complevelInput.Value = 2;
            }
        }
    }
}
