using Dinjo.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Gui.Core.Contracts.Views.Base;

namespace WinForms.Demo.Gui.Core.Contracts.Presenters.Base
{
    public interface IEntityDetailPresenter<T,VIEW> : IPresenter<VIEW> where T: Entity where VIEW : IView
    {
        void OnSave(T entity);
    }
}
