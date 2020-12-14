namespace DemoProject.Views
{
    partial class RegistrationForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(461, 358);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 49);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // tBPassword
            // 
            this.tBPassword.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.Location = new System.Drawing.Point(360, 292);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(261, 40);
            this.tBPassword.TabIndex = 10;
            this.tBPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(154, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // tBName
            // 
            this.tBName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBName.Location = new System.Drawing.Point(360, 173);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(261, 40);
            this.tBName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registration";
            // 
            // tBUsername
            // 
            this.tBUsername.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUsername.Location = new System.Drawing.Point(360, 231);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(261, 40);
            this.tBUsername.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(154, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 513);
            this.Controls.Add(this.tBUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.Label label4;
    }
}