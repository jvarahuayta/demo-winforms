using Dinjo.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Demo.Gui.Core.Contracts.Views.Base
{
    public interface IEntityListView<T>: IView where T: Entity
    {
        void ShowEntities(List<T> entities);
        void GoToCreateEntity();
        void GoToEditEntity(T entity);
        bool OpenConfirmDialog();
    }
}
