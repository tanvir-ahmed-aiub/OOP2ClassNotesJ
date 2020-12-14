namespace DemoProject.Views
{
    partial class DashboardForm
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
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(217, 73);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(256, 20);
            this.tBSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(493, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(276, 133);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 20);
            this.tBName.TabIndex = 3;
            // 
            // tBUsername
            // 
            this.tBUsername.Enabled = false;
            this.tBUsername.Location = new System.Drawing.Point(276, 163);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(100, 20);
            this.tBUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Location = new System.Drawing.Point(301, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(220, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // gridUsers
            // 
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(220, 265);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.Size = new System.Drawing.Size(332, 150);
            this.gridUsers.TabIndex = 8;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tBUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tBSearch);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gridUsers;
    }
}