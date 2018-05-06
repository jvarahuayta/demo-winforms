using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Demo.Gui.Presenters.Base
{
    public class BasePresenter<VIEW> :
        Core.Contracts.Presenters.Base.IPresenter<VIEW> where VIEW : Core.Contracts.Views.Base.IView
    {
        protected VIEW view;

        public void SetView(VIEW view)
        {
            this.view = view;
        }
    }
}
