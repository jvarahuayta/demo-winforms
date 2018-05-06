using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Demo.Gui.Core.Contracts.Views.Base
{
    public interface IView
    {
        void ShowLoading();
        void HideLoading();
        void Init();
    }
}
