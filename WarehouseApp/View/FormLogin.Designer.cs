namespace WarehouseApp.View
{
    partial class FormLogin
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
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.BackColor = System.Drawing.SystemColors.Window;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LabelUsername.Location = new System.Drawing.Point(124, 109);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(87, 21);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Username";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.SystemColors.Window;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LabelPassword.Location = new System.Drawing.Point(124, 148);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(82, 21);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "Password";
            // 
            // TextUsername
            // 
            this.TextUsername.BackColor = System.Drawing.SystemColors.Window;
            this.TextUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextUsername.Location = new System.Drawing.Point(212, 112);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(151, 20);
            this.TextUsername.TabIndex = 2;
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(212, 148);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(151, 20);
            this.TextPassword.TabIndex = 3;
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.BackColor = System.Drawing.SystemColors.Window;
            this.SignIn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SignIn.Location = new System.Drawing.Point(184, 41);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(117, 45);
            this.SignIn.TabIndex = 4;
            this.SignIn.Text = "LOGIN";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(128, 186);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(114, 27);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "Sign In";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Location = new System.Drawing.Point(248, 186);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(115, 27);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(505, 276);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Name = "FormLogin";
            this.Text = "Form Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label SignIn;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonClose;
    }
}