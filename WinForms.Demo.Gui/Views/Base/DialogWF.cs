using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Gui.Core.Contracts.Views.Base;

namespace WinForms.Demo.Gui.Views.Base
{
    public class DialogWF<DATA,RESULT> : BaseWF, IDialogView<DATA,RESULT>
    {
        protected Action<RESULT> _onClose = (a) => { };
        protected DATA data;

        public Action<RESULT> OnClose
        {
            get
            {
                return _onClose;
            }

            set
            {
                _onClose = value;
            }
        }

        public void OpenDialog(DATA data)
        {
            this.data = data;
            this.Init();
        }

        public void Hide()
        {
            base.Hide();
        }
    }
}
