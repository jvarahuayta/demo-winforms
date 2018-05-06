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
using WinForms.Demo.Core.Services;
using WinForms.Demo.Gui.Core.Contracts.Presenters;
using WinForms.Demo.Gui.Core.Contracts.Views;

namespace WinForms.Demo.Gui.Views
{
    public partial class TeamMemberListWF : Base.BaseWF, Core.Contracts.Views.ITeamMemberListView
    {
        protected ITeamMemberListPresenter presenter;
        protected ITeamMemberDetailsView detailsView;

        public TeamMemberListWF(ITeamMemberListPresenter presenter,
            ITeamMemberDetailsView detailsView)
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

        public void GoToEditEntity(TeamMember entity)
        {
            detailsView.OpenDialog(entity);
        }

        public bool OpenConfirmDialog()
        {
            var resp = MetroMessageBox.Show(this, "Eliminar el registro?","Eliminar",MessageBoxButtons.OKCancel);
            return resp == DialogResult.OK;
        }

        public void ShowEntities(List<TeamMember> entities)
        {
            gvTeamMembers.DataSource = entities;
        }

        public override void Init()
        {
            this.presenter.LoadEntities();
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter.OnCreateEntity();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvTeamMembers.SelectedRows[0] != null)
            {
                var teamMember = gvTeamMembers.SelectedRows[0].DataBoundItem as TeamMember;
                presenter.OnEditEntity(teamMember);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvTeamMembers.SelectedRows[0] != null)
            {
                var teamMember = gvTeamMembers.SelectedRows[0].DataBoundItem as TeamMember;
                presenter.OnDeleteEntity(teamMember);
            }
        }
    }
}
