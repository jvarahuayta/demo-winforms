using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Gui.Core.Contracts.Views.Base;

namespace WinForms.Demo.Gui.Core.Contracts.Views
{
    public interface IPlatformView: IView
    {
        void GoToModule(string moduleName);
    }
}
