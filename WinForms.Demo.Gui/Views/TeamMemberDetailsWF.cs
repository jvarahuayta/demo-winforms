using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Views.Base;
using WinForms.Demo.Gui.Core.Contracts.Presenters;
using WinForms.Demo.Core.Domain;

namespace WinForms.Demo.Gui.Views
{
    public partial class TeamMemberDetailsWF : DialogWF<TeamMember,bool>, ITeamMemberDetailsView
    {
        protected int? Id;
        ITeamMemberDetailsPresenter presenter;

        public TeamMemberDetailsWF(ITeamMemberDetailsPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
            presenter.SetView(this);
            FormClosing += base.OnFormClosing;
        }

        public override void Init()
        {
            this.Show();
            if(this.data == null)
            {
                Text = "Crear Miembro de Equipo";
                Id = null;
            }else
            {
                Id = data.Id;
                Text = "Editar Miembro de Equipo";
                txtEmail.Text = data.Email;
                txtFirstName.Text = data.FirstName;
                txtLastName.Text = data.LastName;

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            presenter.OnSave(new TeamMember()
            {
                Id = Id,
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            });
        }
    }
}
