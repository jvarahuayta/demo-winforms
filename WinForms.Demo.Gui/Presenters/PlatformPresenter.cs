using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Core.Contracts.Presenters;

namespace WinForms.Demo.Gui.Presenters
{
    public class PlatformPresenter : Base.BasePresenter<IPlatformView>, IPlatformPresenter
    {
        public void OnModuleClick(string moduleName)
        {
            view.GoToModule(moduleName);
        }
    }
}
