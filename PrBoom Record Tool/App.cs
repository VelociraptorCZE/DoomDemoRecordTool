using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PrBoomRecordTool
{
    public partial class App : Form
    {
        private readonly FileLoader fileLoader;
        private readonly DemoRecorder demoRecorder;

        public App()
        {
            InitializeComponent();
            fileLoader = new FileLoader(this);
            demoRecorder = new DemoRecorder(this);
        }

        private void PlayDemoButtonOnClick(object sender, EventArgs e)
        {
            demoRecorder.PlayRecording();
        }

        private void RecordDemoButtonOnClick(object sender, EventArgs e)
        {
            demoRecorder.StartRecording();   
        }

        private void OpenPrBoomDialogFileLoaded(object sender, CancelEventArgs e)
        {
            fileLoader.LoadPrBoom();
        }

        private void OpenIwadDialogFileLoaded(object sender, CancelEventArgs e)
        {
            fileLoader.LoadIwad();
        }

        private void LocateIwadButtonOnClick(object sender, EventArgs e)
        {
            openIwadDialog.ShowDialog();
        }

        private void LocatePrBoomButtonOnClick(object sender, EventArgs e)
        {
            openPrBoomDialog.ShowDialog();
        }

        private void IsEpisodeActiveOnChange(object sender, EventArgs e)
        {
            episodeInput.Enabled = isEpisodeActiveCheckbox.Checked;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            skillSelect.SelectedIndex = 3;

            try
            {
                string iwadPath = Properties.Settings.Default.IwadPath;
                string prBoomPath = Properties.Settings.Default.PrBoomPath;

                if (iwadPath.Length != 0)
                {
                    iwadPathLabel.Text = iwadPath;
                }

                if (prBoomPath.Length != 0)
                {
                    prBoomPathLabel.Text = prBoomPath;
                }
            } catch {}
        }
    }
}
