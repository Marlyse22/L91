namespace L91
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.home_panel2 = new System.Windows.Forms.Panel();
            this.main_panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.home_panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.home_panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 681);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // home_panel2
            // 
            this.home_panel2.BackColor = System.Drawing.Color.Transparent;
            this.home_panel2.Controls.Add(this.main_panel2);
            this.home_panel2.Location = new System.Drawing.Point(0, 176);
            this.home_panel2.Name = "home_panel2";
            this.home_panel2.Size = new System.Drawing.Size(153, 44);
            this.home_panel2.TabIndex = 0;
            this.home_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // main_panel2
            // 
            this.main_panel2.BackColor = System.Drawing.Color.Transparent;
            this.main_panel2.Location = new System.Drawing.Point(3, 47);
            this.main_panel2.Name = "main_panel2";
            this.main_panel2.Size = new System.Drawing.Size(153, 33);
            this.main_panel2.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.home_panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel home_panel2;
        private System.Windows.Forms.Panel main_panel2;
    }
}