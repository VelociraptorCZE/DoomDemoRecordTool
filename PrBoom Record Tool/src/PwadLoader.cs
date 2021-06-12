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
            UpdatePwadListView(wads);
        }

        private void UpdatePwadListView(string[] wads)
        {
            foreach (ListViewItem item in app.pwadListView.Items)
            {
                item.Remove();
            }

            foreach (string wad in wads)
            {
                ListViewItem item = new ListViewItem();
                item.Text = wad;
                app.pwadListView.Items.Add(item);
            }
        }

        public string GetPwads()
        {
            if (app.pwadListView.Items.Count == 0)
            {
                return "";
            }

            string pwads = "";

            foreach (ListViewItem item in app.pwadListView.Items)
            {
                pwads += $"{item.Text} ";
            }

            return $"-file {pwads}";
        }
    }
}
