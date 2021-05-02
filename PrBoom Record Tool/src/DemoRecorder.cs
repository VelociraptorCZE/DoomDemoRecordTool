using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PrBoomRecordTool
{
    class DemoRecorder
    {
        private readonly App app;

        public DemoRecorder(App app)
        {
            this.app = app;
        }

        public void StartRecording()
        {
            if (!IsRecordToolReady()) 
            {
                return;
            }

            File.Delete(GenerateDemoPath());

            CreateProcess(GetRecordArguments()).Start();
        }

        public void PlayRecording()
        {
            if (!IsRecordToolReady())
            {
                return;
            }

            CreateProcess(GetPlayArguments()).Start();
        }

        private bool IsRecordToolReady()
        {
            bool isReady = Properties.Settings.Default.PrBoomPath.Length != 0;

            if (!isReady) 
            {
                MessageBox.Show(
                    "You haven't probably set up path to your prboom/glboom. " +
                    "Set this path to be able to record and play demos."
                );
            }

            return isReady;
        }

        private string GetPlayArguments()
        {
            return $@"
                -iwad {app.iwadPathLabel.Text}
                -playdemo {GenerateDemoPath()}
                -complevel {app.complevelInput.Value}
            ";
        }

        private string GetRecordArguments() 
        {
            string episode = app.episodeInput.Enabled ? app.episodeInput.Value.ToString() : "";

            return $@"
                -iwad {app.iwadPathLabel.Text}
                -record {GenerateDemoPath()}
                -warp {episode} {app.levelInput.Value}
                -complevel {app.complevelInput.Value}
                -skill {app.skillSelect.SelectedIndex + 1}
            ";
        }

        private Process CreateProcess(string arguments)
        {
            return new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = app.prBoomPathLabel.Text,
                    Arguments = arguments,
                    CreateNoWindow = true
                },
            };
        }

        private string GenerateDemoPath()
        {
            return $@"{DirectoryTools.GetDirectory(app.prBoomPathLabel.Text)}\{app.demoNameInput.Text}.lmp";
        }
    }
}
