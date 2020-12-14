namespace DemoProject.Views
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // tBUsername
            // 
            this.tBUsername.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUsername.Location = new System.Drawing.Point(327, 108);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(261, 40);
            this.tBUsername.TabIndex = 2;
            // 
            // tBPassword
            // 
            this.tBPassword.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.Location = new System.Drawing.Point(327, 183);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(261, 40);
            this.tBPassword.TabIndex = 4;
            this.tBPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(452, 265);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 49);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(127, 267);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(291, 45);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Not Registered?";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 426);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}