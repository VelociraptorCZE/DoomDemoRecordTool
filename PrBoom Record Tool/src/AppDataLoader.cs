namespace PrBoomRecordTool
{
    class AppDataLoader
    {
        private App app;

        public AppDataLoader(App app)
        {
            this.app = app;
        }

        public void FillInputsWithAppData()
        {
            app.skillSelect.SelectedIndex = Config.GetDifficulty();
            app.complevelInput.Value = Config.GetComplevel();
            app.levelInput.Value = Config.GetLevel();
            app.episodeInput.Value = Config.GetEpisode();

            app.isEpisodeActiveCheckbox.Checked = Config.HasIwadEpisodes();
            app.respawnCheckbox.Checked = Config.IsRespawn();
            app.fastMonstersCheckbox.Checked = Config.IsFast();
            app.noMonstersCheckbox.Checked = Config.IsNoMo();

            try
            {
                string iwadPath = Config.GetIwadPath();
                string prBoomPath = Config.GetPrBoomPath();
                string lastDemoName = Config.GetLastDemoName();

                if (iwadPath.Length != 0)
                {
                    app.iwadPathLabel.Text = iwadPath;
                }

                if (prBoomPath.Length != 0)
                {
                    app.prBoomPathLabel.Text = prBoomPath;
                }

                if (lastDemoName.Length != 0)
                {
                    app.saveDemoDialog.FileName = lastDemoName;
                    app.demoNameInput.Text = lastDemoName;
                }
            }
            catch { }
        }
    }
}
