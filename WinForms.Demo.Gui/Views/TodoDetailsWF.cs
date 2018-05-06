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
    public partial class TodoDetailsWF : DialogWF<Todo,bool>, ITodoDetailsView
    {
        protected int? Id;
        ITodoDetailsPresenter presenter;

        public TodoDetailsWF(ITodoDetailsPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
            presenter.SetView(this);
            FormClosing += base.OnFormClosing;
        }

        public override void Init()
        {
            this.Show();
            if (this.data == null)
            {
                Text = "Crear Miembro de Equipo";
                Id = null;
            }
            else
            {
                Id = data.Id;
                Text = "Editar Miembro de Equipo";
                txtTitle.Text = data.Title;
                txtDescription.Text = data.Description;
                ckbFinished.Checked = data.Finished;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.OnSave(new Todo()
            {
                Id = Id,
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Finished = ckbFinished.Checked
            });
        }
    }
}
