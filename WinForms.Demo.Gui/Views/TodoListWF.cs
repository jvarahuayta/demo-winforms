using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Demo.Core.Domain;
using WinForms.Demo.Gui.Core.Contracts.Presenters;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Views.Base;

namespace WinForms.Demo.Gui.Views
{
    public partial class TodoListWF : BaseWF, ITodoListView
    {
        ITodoListPresenter presenter;
        ITodoDetailsView detailsView;

        public TodoListWF(ITodoListPresenter presenter,
            ITodoDetailsView detailsView)
        {
            InitializeComponent();
            this.presenter = presenter;
            this.detailsView = detailsView;
            this.FormClosing += base.OnFormClosing;
            detailsView.OnClose = (success) => { presenter.LoadEntities(); };
            presenter.SetView(this);
        }

        public void GoToCreateEntity()
        {
            detailsView.OpenDialog(null);
        }

        public void GoToEditEntity(Todo entity)
        {
            detailsView.OpenDialog(entity);
        }

        public bool OpenConfirmDialog()
        {
            var resp = MetroMessageBox.Show(this, "Eliminar el registro?", "Eliminar", MessageBoxButtons.OKCancel);
            return resp == DialogResult.OK;
        }

        public void ShowEntities(List<Todo> entities)
        {
            gvTodos.DataSource = entities;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.OnCreateEntity();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvTodos.SelectedRows[0] != null)
            {
                var todo = gvTodos.SelectedRows[0].DataBoundItem as Todo;
                presenter.OnEditEntity(todo);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvTodos.SelectedRows[0] != null)
            {
                var todo = gvTodos.SelectedRows[0].DataBoundItem as Todo;
                presenter.OnDeleteEntity(todo);
            }
        }

        public override void Init()
        {
            this.presenter.LoadEntities();
            this.Show();
        }
    }
}
