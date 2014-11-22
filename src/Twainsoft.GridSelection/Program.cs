using System;
using System.Windows.Forms;

namespace Twainsoft.GridSelection
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GridSelectionView());
        }
    }
}
