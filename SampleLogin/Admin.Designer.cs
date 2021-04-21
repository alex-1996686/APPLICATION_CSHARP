namespace SampleLogin
{
    partial class Admin
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Utilisateurs = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.Salons = new System.Windows.Forms.TabPage();
            this.Journal = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Utilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(13, 13);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(60, 24);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Utilisateurs);
            this.tabControl1.Controls.Add(this.Salons);
            this.tabControl1.Controls.Add(this.Journal);
            this.tabControl1.Location = new System.Drawing.Point(16, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 344);
            this.tabControl1.TabIndex = 1;
            // 
            // Utilisateurs
            // 
            this.Utilisateurs.Controls.Add(this.button4);
            this.Utilisateurs.Controls.Add(this.button3);
            this.Utilisateurs.Controls.Add(this.button2);
            this.Utilisateurs.Controls.Add(this.dataGridUsers);
            this.Utilisateurs.Location = new System.Drawing.Point(4, 22);
            this.Utilisateurs.Name = "Utilisateurs";
            this.Utilisateurs.Padding = new System.Windows.Forms.Padding(3);
            this.Utilisateurs.Size = new System.Drawing.Size(635, 318);
            this.Utilisateurs.TabIndex = 0;
            this.Utilisateurs.Text = "Utilisateurs";
            this.Utilisateurs.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(554, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(6, 6);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(626, 276);
            this.dataGridUsers.TabIndex = 0;
            // 
            // Salons
            // 
            this.Salons.Location = new System.Drawing.Point(4, 22);
            this.Salons.Name = "Salons";
            this.Salons.Padding = new System.Windows.Forms.Padding(3);
            this.Salons.Size = new System.Drawing.Size(635, 318);
            this.Salons.TabIndex = 1;
            this.Salons.Text = "Salons";
            this.Salons.UseVisualStyleBackColor = true;
            // 
            // Journal
            // 
            this.Journal.Location = new System.Drawing.Point(4, 22);
            this.Journal.Name = "Journal";
            this.Journal.Size = new System.Drawing.Size(635, 318);
            this.Journal.TabIndex = 2;
            this.Journal.Text = "Journal";
            this.Journal.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 413);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelUsername);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.Utilisateurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Utilisateurs;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TabPage Salons;
        private System.Windows.Forms.TabPage Journal;
    }
}