using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Gui.Core.Contracts.Views.Base;

namespace WinForms.Demo.Gui.Core.Contracts.Views.Base
{
    public interface IDialogView<DATA,RESULT> : IView
    {
        void OpenDialog(DATA data);

        void Hide();

        Action<RESULT> OnClose { get; set; }
    }
}
