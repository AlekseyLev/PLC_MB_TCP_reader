using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace xxx_degazator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            ApplicationConfiguration.Initialize();                        
            Application.Run(new Form1());
            
        }
    }
}