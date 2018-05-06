using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Core.Services;
using WinForms.Demo.Gui.Core.Contracts.Presenters;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Presenters.Base;

namespace WinForms.Demo.Gui.Presenters
{
    public class TodoListPresenter : BasePresenter<ITodoListView>, ITodoListPresenter
    {
        ITodosManager manager;

        public TodoListPresenter(ITodosManager manager)
        {
            this.manager = manager;
        }

        public void LoadEntities()
        {
            view.ShowEntities(manager.GetAll());
        }

        public void OnCreateEntity()
        {
            view.GoToCreateEntity();
        }

        public void OnDeleteEntity(Todo entity)
        {
            if (view.OpenConfirmDialog())
            {
                manager.Delete(entity);
            }
        }

        public void OnEditEntity(Todo entity)
        {
            view.GoToEditEntity(entity);
        }
    }
}
