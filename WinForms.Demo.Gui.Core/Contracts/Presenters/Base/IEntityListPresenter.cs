using Dinjo.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Gui.Core.Contracts.Views.Base;

namespace WinForms.Demo.Gui.Core.Contracts.Presenters.Base
{
    public interface IEntityListPresenter<T,VIEW> : IPresenter<VIEW> where T: Entity where VIEW : IView
    {
        void LoadEntities();
        void OnCreateEntity();
        void OnEditEntity(T entity);
        void OnDeleteEntity(T entity);
        void OnConfirmDeleteEntity(bool result);
    }
}
