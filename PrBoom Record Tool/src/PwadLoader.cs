using System.Windows.Forms;

namespace PrBoomRecordTool
{
    class PwadLoader
    {
        private App app;

        public PwadLoader(App app)
        {
            this.app = app;
        }

        public void LoadPwads()
        {
            string[] wads = app.openPwadDialog.FileNames;
            SavePwads(wads);
            UpdatePwadListView(wads);
        }

        public void UpdatePwadListView(string[] wads)
        {
            foreach (ListViewItem item in app.pwadListView.Items)
            {
                item.Remove();
            }

            foreach (string wad in wads)
            {
                app.pwadListView.Items.Add(new ListViewItem { Text = wad });
            }
        }

        private void SavePwads(string[] wads)
        {
            Config.Save("Pwads", string.Join("|", wads));;
        }
    }
}
