using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI1;

namespace WinUI1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Anket());
=======
            Application.Run(new PersonelBligiGirisi());
>>>>>>> 259877f329cecf37375e454ca0e156787b232924
        }
    }
}
