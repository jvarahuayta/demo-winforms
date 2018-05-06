using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using WinForms.Demo.Gui.Core.Contracts.Views.Base;
using System.Windows.Forms;

namespace WinForms.Demo.Gui.Views.Base
{
    public class BaseWF : MetroForm, IView
    {

        public void HideLoading()
        {
            throw new NotImplementedException();
        }

        public virtual void Init()
        {

        }

        public void ShowLoading()
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseWF
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "BaseWF";
            this.ResumeLayout(false);

        }

        protected void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
