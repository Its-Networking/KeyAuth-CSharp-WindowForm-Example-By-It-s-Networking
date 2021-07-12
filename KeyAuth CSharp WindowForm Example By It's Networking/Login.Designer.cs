
namespace KeyAuth_CSharp_WindowForm_Example_By_It_s_Networking
{
    partial class Login
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
            this.usernameBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.passwordBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.loginBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.registerBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.rememberMeCB = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.titleLbl = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultText = "";
            this.usernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.DisabledState.Parent = this.usernameBox;
            this.usernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.FocusedState.Parent = this.usernameBox;
            this.usernameBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.HoveredState.Parent = this.usernameBox;
            this.usernameBox.Location = new System.Drawing.Point(12, 106);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PlaceholderText = "Username";
            this.usernameBox.SelectedText = "";
            this.usernameBox.ShadowDecoration.Parent = this.usernameBox;
            this.usernameBox.Size = new System.Drawing.Size(344, 36);
            this.usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.Parent = this.passwordBox;
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.FocusedState.Parent = this.passwordBox;
            this.passwordBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.HoveredState.Parent = this.passwordBox;
            this.passwordBox.Location = new System.Drawing.Point(12, 148);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.PlaceholderText = "Password";
            this.passwordBox.SelectedText = "";
            this.passwordBox.ShadowDecoration.Parent = this.passwordBox;
            this.passwordBox.Size = new System.Drawing.Size(344, 36);
            this.passwordBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoveredState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(12, 190);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(170, 35);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.CheckedState.Parent = this.registerBtn;
            this.registerBtn.CustomImages.Parent = this.registerBtn;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.HoveredState.Parent = this.registerBtn;
            this.registerBtn.Location = new System.Drawing.Point(186, 190);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.ShadowDecoration.Parent = this.registerBtn;
            this.registerBtn.Size = new System.Drawing.Size(170, 35);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // rememberMeCB
            // 
            this.rememberMeCB.AutoSize = true;
            this.rememberMeCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rememberMeCB.CheckedState.BorderRadius = 2;
            this.rememberMeCB.CheckedState.BorderThickness = 0;
            this.rememberMeCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rememberMeCB.Location = new System.Drawing.Point(136, 243);
            this.rememberMeCB.Name = "rememberMeCB";
            this.rememberMeCB.Size = new System.Drawing.Size(95, 17);
            this.rememberMeCB.TabIndex = 4;
            this.rememberMeCB.Text = "Remember Me";
            this.rememberMeCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rememberMeCB.UncheckedState.BorderRadius = 2;
            this.rememberMeCB.UncheckedState.BorderThickness = 0;
            this.rememberMeCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rememberMeCB.UseVisualStyleBackColor = true;
            this.rememberMeCB.CheckedChanged += new System.EventHandler(this.rememberMeCB_CheckedChanged);
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(136, 12);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(92, 41);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Text = "Login";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(342, 12);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(14, 22);
            this.siticoneLabel1.TabIndex = 6;
            this.siticoneLabel1.Text = "X";
            this.siticoneLabel1.Click += new System.EventHandler(this.siticoneLabel1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(368, 377);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.rememberMeCB);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneRoundedTextBox usernameBox;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox passwordBox;
        private Siticone.UI.WinForms.SiticoneRoundedButton loginBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton registerBtn;
        private Siticone.UI.WinForms.SiticoneCheckBox rememberMeCB;
        private Siticone.UI.WinForms.SiticoneLabel titleLbl;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}

