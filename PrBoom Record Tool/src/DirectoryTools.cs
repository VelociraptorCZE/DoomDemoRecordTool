using System.Windows.Forms;

namespace PrBoomRecordTool
{
    class DirectoryTools
    {
        public static string GetDirectory(string path)
        {
            int lastSlashPosition = path.LastIndexOf(@"\");

            return lastSlashPosition == -1 ? path : path.Substring(0, lastSlashPosition);
        }
    }
}
