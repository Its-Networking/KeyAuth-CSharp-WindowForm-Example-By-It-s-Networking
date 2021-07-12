
namespace KeyAuth_CSharp_WindowForm_Example_By_It_s_Networking
{
    partial class Register
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
            this.titleLbl = new Siticone.UI.WinForms.SiticoneLabel();
            this.registerBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.loginBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.regpasswordBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.regusernameBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.regConfirmPasswordBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.regKeyBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(112, 12);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(141, 41);
            this.titleLbl.TabIndex = 11;
            this.titleLbl.Text = "Register";
            // 
            // registerBtn
            // 
            this.registerBtn.CheckedState.Parent = this.registerBtn;
            this.registerBtn.CustomImages.Parent = this.registerBtn;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.HoveredState.Parent = this.registerBtn;
            this.registerBtn.Location = new System.Drawing.Point(184, 274);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.ShadowDecoration.Parent = this.registerBtn;
            this.registerBtn.Size = new System.Drawing.Size(170, 35);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoveredState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(10, 274);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(170, 35);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Return To Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // regpasswordBox
            // 
            this.regpasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regpasswordBox.DefaultText = "";
            this.regpasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regpasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regpasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regpasswordBox.DisabledState.Parent = this.regpasswordBox;
            this.regpasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regpasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regpasswordBox.FocusedState.Parent = this.regpasswordBox;
            this.regpasswordBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regpasswordBox.HoveredState.Parent = this.regpasswordBox;
            this.regpasswordBox.Location = new System.Drawing.Point(10, 148);
            this.regpasswordBox.Name = "regpasswordBox";
            this.regpasswordBox.PasswordChar = '\0';
            this.regpasswordBox.PlaceholderText = "Password";
            this.regpasswordBox.SelectedText = "";
            this.regpasswordBox.ShadowDecoration.Parent = this.regpasswordBox;
            this.regpasswordBox.Size = new System.Drawing.Size(344, 36);
            this.regpasswordBox.TabIndex = 7;
            // 
            // regusernameBox
            // 
            this.regusernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regusernameBox.DefaultText = "";
            this.regusernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regusernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regusernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regusernameBox.DisabledState.Parent = this.regusernameBox;
            this.regusernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regusernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regusernameBox.FocusedState.Parent = this.regusernameBox;
            this.regusernameBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regusernameBox.HoveredState.Parent = this.regusernameBox;
            this.regusernameBox.Location = new System.Drawing.Point(10, 106);
            this.regusernameBox.Name = "regusernameBox";
            this.regusernameBox.PasswordChar = '\0';
            this.regusernameBox.PlaceholderText = "Username";
            this.regusernameBox.SelectedText = "";
            this.regusernameBox.ShadowDecoration.Parent = this.regusernameBox;
            this.regusernameBox.Size = new System.Drawing.Size(344, 36);
            this.regusernameBox.TabIndex = 6;
            // 
            // regConfirmPasswordBox
            // 
            this.regConfirmPasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regConfirmPasswordBox.DefaultText = "";
            this.regConfirmPasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regConfirmPasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regConfirmPasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regConfirmPasswordBox.DisabledState.Parent = this.regConfirmPasswordBox;
            this.regConfirmPasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regConfirmPasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regConfirmPasswordBox.FocusedState.Parent = this.regConfirmPasswordBox;
            this.regConfirmPasswordBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regConfirmPasswordBox.HoveredState.Parent = this.regConfirmPasswordBox;
            this.regConfirmPasswordBox.Location = new System.Drawing.Point(10, 190);
            this.regConfirmPasswordBox.Name = "regConfirmPasswordBox";
            this.regConfirmPasswordBox.PasswordChar = '\0';
            this.regConfirmPasswordBox.PlaceholderText = "Confirm Password";
            this.regConfirmPasswordBox.SelectedText = "";
            this.regConfirmPasswordBox.ShadowDecoration.Parent = this.regConfirmPasswordBox;
            this.regConfirmPasswordBox.Size = new System.Drawing.Size(344, 36);
            this.regConfirmPasswordBox.TabIndex = 12;
            this.regConfirmPasswordBox.TextChanged += new System.EventHandler(this.regConfirmPasswordBox_TextChanged);
            // 
            // regKeyBox
            // 
            this.regKeyBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regKeyBox.DefaultText = "";
            this.regKeyBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regKeyBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regKeyBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regKeyBox.DisabledState.Parent = this.regKeyBox;
            this.regKeyBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regKeyBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regKeyBox.FocusedState.Parent = this.regKeyBox;
            this.regKeyBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regKeyBox.HoveredState.Parent = this.regKeyBox;
            this.regKeyBox.Location = new System.Drawing.Point(12, 232);
            this.regKeyBox.Name = "regKeyBox";
            this.regKeyBox.PasswordChar = '\0';
            this.regKeyBox.PlaceholderText = "Key";
            this.regKeyBox.SelectedText = "";
            this.regKeyBox.ShadowDecoration.Parent = this.regKeyBox;
            this.regKeyBox.Size = new System.Drawing.Size(344, 36);
            this.regKeyBox.TabIndex = 14;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(342, 12);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(14, 22);
            this.siticoneLabel1.TabIndex = 15;
            this.siticoneLabel1.Text = "X";
            this.siticoneLabel1.Click += new System.EventHandler(this.siticoneLabel1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(368, 377);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.regKeyBox);
            this.Controls.Add(this.regConfirmPasswordBox);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.regpasswordBox);
            this.Controls.Add(this.regusernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneLabel titleLbl;
        private Siticone.UI.WinForms.SiticoneRoundedButton registerBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton loginBtn;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox regpasswordBox;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox regusernameBox;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox regConfirmPasswordBox;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox regKeyBox;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}