
namespace KeyAuth_CSharp_WindowForm_Example_By_It_s_Networking
{
    partial class MainForm
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
            this.userDataBox = new LogIn_Theme_Dll_By_xVenoxi.LogInTitledListBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.SuspendLayout();
            // 
            // userDataBox
            // 
            this.userDataBox.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.userDataBox.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.userDataBox.Items = new string[] {
        ""};
            this.userDataBox.ListBaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.userDataBox.Location = new System.Drawing.Point(12, 12);
            this.userDataBox.Name = "userDataBox";
            this.userDataBox.SelectedColour = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.userDataBox.Size = new System.Drawing.Size(229, 440);
            this.userDataBox.TabIndex = 0;
            this.userDataBox.Text = "User Data";
            this.userDataBox.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userDataBox.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(761, 12);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(14, 22);
            this.siticoneLabel1.TabIndex = 7;
            this.siticoneLabel1.Text = "X";
            this.siticoneLabel1.Click += new System.EventHandler(this.siticoneLabel1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(787, 464);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.userDataBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LogIn_Theme_Dll_By_xVenoxi.LogInTitledListBox userDataBox;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}