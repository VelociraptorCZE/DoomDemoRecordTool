using System.Linq;
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
            UpdatePwadList(app.openPwadDialog.FileNames);
        }

        public void UnloadPwad(string pwad)
        {
            UpdatePwadList(Config.GetPwads().Where(wad => wad != pwad).ToArray());
        }

        public void UpdatePwadList(string[] wads)
        {
            Config.Save("Pwads", string.Join("|", wads));

            foreach (ListViewItem item in app.pwadListView.Items)
            {
                item.Remove();
            }

            foreach (string wad in wads)
            {
                app.pwadListView.Items.Add(new ListViewItem { Text = wad });
            }
        }
    }
}
