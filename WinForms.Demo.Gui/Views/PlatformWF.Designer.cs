namespace WinForms.Demo.Gui.Views
{
    partial class PlatformWF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnTeamMembers = new MetroFramework.Controls.MetroButton();
            this.btnTodos = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(115, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Módulos";
            // 
            // btnTeamMembers
            // 
            this.btnTeamMembers.Location = new System.Drawing.Point(78, 116);
            this.btnTeamMembers.Name = "btnTeamMembers";
            this.btnTeamMembers.Size = new System.Drawing.Size(138, 23);
            this.btnTeamMembers.TabIndex = 3;
            this.btnTeamMembers.TabStop = false;
            this.btnTeamMembers.Text = "Miembros del equipo";
            this.btnTeamMembers.UseSelectable = true;
            this.btnTeamMembers.Click += new System.EventHandler(this.btnTeamMembers_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(78, 164);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(138, 23);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.TabStop = false;
            this.btnTodos.Text = "TODOs";
            this.btnTodos.UseSelectable = true;
            // 
            // PlatformWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnTeamMembers);
            this.Controls.Add(this.metroLabel1);
            this.Name = "PlatformWF";
            this.Text = "Plataforma TODOs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnTeamMembers;
        private MetroFramework.Controls.MetroButton btnTodos;
    }
}