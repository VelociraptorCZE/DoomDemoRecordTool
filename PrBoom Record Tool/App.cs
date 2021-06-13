using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PrBoomRecordTool
{
    public partial class App : Form
    {
        private readonly FileLoader fileLoader;
        private readonly PwadLoader pwadLoader;
        private readonly DemoRecorder demoRecorder;
        private readonly AppDataLoader appDataLoader;

        public App()
        {
            InitializeComponent();
            fileLoader = new FileLoader(this);
            pwadLoader = new PwadLoader(this);
            demoRecorder = new DemoRecorder(this);
            appDataLoader = new AppDataLoader(this);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            appDataLoader.FillInputsWithAppData();
            pwadLoader.UpdatePwadList(Config.GetPwads());
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

        private void OpenPwadDialogFileLoaded(object sender, CancelEventArgs e)
        {
            pwadLoader.LoadPwads();
        }

        private void LocateIwadButtonOnClick(object sender, EventArgs e)
        {
            openIwadDialog.ShowDialog();
        }

        private void LocatePrBoomButtonOnClick(object sender, EventArgs e)
        {
            openPrBoomDialog.ShowDialog();
        }

        private void LocatePwadButtonOnClick(object sender, EventArgs e)
        {
            openPwadDialog.ShowDialog();
        }

        private void UnloadPwadButtonOnClick(object sender, EventArgs e)
        {
            if (pwadListView.SelectedItems.Count == 1)
            {
                pwadLoader.UnloadPwad(pwadListView.SelectedItems[0]?.Text ?? "");
            }
        }

        private void SetDemoPathButtonClick(object sender, EventArgs e)
        {
            DialogResult result = saveDemoDialog.ShowDialog();

            if (result == DialogResult.OK) 
            {
                demoNameInput.Text = saveDemoDialog.FileName;
                Config.Save("LastDemoName", saveDemoDialog.FileName);
            }
        }

        private void IsEpisodeActiveOnChange(object sender, EventArgs e)
        {
            episodeInput.Enabled = isEpisodeActiveCheckbox.Checked;
            Config.Save("HasIwadEpisodes", isEpisodeActiveCheckbox.Checked);
        }

        private void SkillSelectChanged(object sender, EventArgs e)
        {
            Config.Save("Difficulty", skillSelect.SelectedIndex);
        }

        private void ComplevelInputChanged(object sender, EventArgs e)
        {
            Config.Save("Complevel", (int)complevelInput.Value);
        }

        private void LevelInputChanged(object sender, EventArgs e)
        {
            Config.Save("Level", (int)levelInput.Value);
        }

        private void EpisodeInputChanged(object sender, EventArgs e)
        {
            Config.Save("Episode", (int)episodeInput.Value);
        }

        private void NoMonstersCheckboxChanged(object sender, EventArgs e)
        {
            bool isNoMo = noMonstersCheckbox.Checked;
            Config.Save("IsNoMo", isNoMo);
            fastMonstersCheckbox.Enabled = !isNoMo;
            respawnCheckbox.Enabled = !isNoMo;
        }

        private void FastMonstersCheckboxChanged(object sender, EventArgs e)
        {
            Config.Save("IsFast", fastMonstersCheckbox.Checked);
        }

        private void RespawnCheckboxChanged(object sender, EventArgs e)
        {
            Config.Save("IsRespawn", respawnCheckbox.Checked);
        }

        private void AboutButtonOnClick(object sender, EventArgs e)
        {
            MessageBox.Show(@"
GUI tool for Classic DOOM demo recording for any source port.

(c) 2021 Šimon Raichl
            ", "About Doom Demo Record Tool");
        }
    }
}
