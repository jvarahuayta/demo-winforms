﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Demo.Gui.Views.Base;
using WinForms.Demo.Gui.Core.Contracts.Views;
using WinForms.Demo.Gui.Core.Contracts.Presenters;

namespace WinForms.Demo.Gui.Views
{
    public partial class PlatformWF : BaseWF, IPlatformView
    {
        IPlatformPresenter presenter;
        ITeamMemberListView teamMemberView;

        public PlatformWF(IPlatformPresenter presenter,
            ITeamMemberListView teamMemberView)
        {
            InitializeComponent();
            this.presenter = presenter;
            this.teamMemberView = teamMemberView;
            presenter.SetView(this);
        }

        public void GoToModule(string moduleName)
        {
            switch (moduleName)
            {
                case "TEAM_MEMBERS":
                    teamMemberView.Init();
                    break;
            }
        }

        public override void Init()
        {

        }

        private void btnTeamMembers_Click(object sender, EventArgs e)
        {
            presenter.OnModuleClick("TEAM_MEMBERS");
        }
    }
}
