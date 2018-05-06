using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using System.Windows.Forms;
using WinForms.Demo.Gui.Core.Contracts.Views;

namespace WinForms.Demo.Gui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( DI.Injector.Container.Resolve<IPlatformView>() as Form );
        }
    }
}
