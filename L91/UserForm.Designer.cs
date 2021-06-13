namespace L91
{
    partial class UserForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roleLb = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prenomTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mdpTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.afficher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roleLb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.prenomTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mdpTb);
            this.groupBox1.Controls.Add(this.emailTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nomTB);
            this.groupBox1.Controls.Add(this.usernameTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un utilisateur";
            // 
            // roleLb
            // 
            this.roleLb.FormattingEnabled = true;
            this.roleLb.Items.AddRange(new object[] {
            "Administateur",
            "Collaborateur"});
            this.roleLb.Location = new System.Drawing.Point(127, 257);
            this.roleLb.Name = "roleLb";
            this.roleLb.Size = new System.Drawing.Size(157, 30);
            this.roleLb.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Role :";
            // 
            // prenomTB
            // 
            this.prenomTB.Location = new System.Drawing.Point(127, 111);
            this.prenomTB.Name = "prenomTB";
            this.prenomTB.Size = new System.Drawing.Size(157, 20);
            this.prenomTB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prénom :";
            // 
            // mdpTb
            // 
            this.mdpTb.Location = new System.Drawing.Point(127, 179);
            this.mdpTb.Name = "mdpTb";
            this.mdpTb.Size = new System.Drawing.Size(157, 20);
            this.mdpTb.TabIndex = 15;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(127, 143);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(157, 20);
            this.emailTb.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email :";
            // 
            // nomTB
            // 
            this.nomTB.Location = new System.Drawing.Point(127, 73);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(157, 20);
            this.nomTB.TabIndex = 11;
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(127, 41);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(157, 20);
            this.usernameTb.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Afficher / Masquer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.White;
            this.ajouter.ForeColor = System.Drawing.Color.Maroon;
            this.ajouter.Location = new System.Drawing.Point(6, 19);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(114, 27);
            this.ajouter.TabIndex = 7;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(335, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 293);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des utilisateurs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.White;
            this.supprimer.ForeColor = System.Drawing.Color.Maroon;
            this.supprimer.Location = new System.Drawing.Point(153, 19);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(114, 27);
            this.supprimer.TabIndex = 9;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.White;
            this.Modifier.ForeColor = System.Drawing.Color.Maroon;
            this.Modifier.Location = new System.Drawing.Point(6, 65);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(114, 29);
            this.Modifier.TabIndex = 10;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.afficher);
            this.groupBox3.Controls.Add(this.ajouter);
            this.groupBox3.Controls.Add(this.Modifier);
            this.groupBox3.Controls.Add(this.supprimer);
            this.groupBox3.Location = new System.Drawing.Point(12, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choix";
            // 
            // afficher
            // 
            this.afficher.BackColor = System.Drawing.Color.White;
            this.afficher.ForeColor = System.Drawing.Color.Maroon;
            this.afficher.Location = new System.Drawing.Point(153, 65);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(114, 29);
            this.afficher.TabIndex = 11;
            this.afficher.Text = "Afficher";
            this.afficher.UseVisualStyleBackColor = false;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prenomTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mdpTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox roleLb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button afficher;
    }
}