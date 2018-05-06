using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Gui.Core.Contracts.Views.Base;

namespace WinForms.Demo.Gui.Core.Contracts.Presenters.Base
{
    public interface IPresenter<VIEW> where VIEW : IView
    {
        void SetView(VIEW view);
    }
}
