using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Gui.Core.Contracts.Views;

namespace WinForms.Demo.Gui.Core.Contracts.Presenters
{
    public interface IPlatformPresenter: Base.IPresenter<IPlatformView>
    {
        void OnModuleClick(string moduleName);
    }
}
