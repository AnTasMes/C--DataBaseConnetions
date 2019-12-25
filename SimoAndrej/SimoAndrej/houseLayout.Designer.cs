namespace SimoAndrej
{
    partial class houseLayout
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikOpcije = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikInformacije = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spratToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spratPrvi = new System.Windows.Forms.ToolStripMenuItem();
            this.spratDrugi = new System.Windows.Forms.ToolStripMenuItem();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcijePanela = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spratToolStripMenuItem,
            this.spratToolStripMenuItem1,
            this.opcijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spratToolStripMenuItem
            // 
            this.spratToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikOpcije,
            this.korisnikInformacije,
            this.logOutToolStripMenuItem});
            this.spratToolStripMenuItem.Name = "spratToolStripMenuItem";
            this.spratToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.spratToolStripMenuItem.Text = "Korisnik";
            // 
            // korisnikOpcije
            // 
            this.korisnikOpcije.Name = "korisnikOpcije";
            this.korisnikOpcije.Size = new System.Drawing.Size(134, 22);
            this.korisnikOpcije.Text = "Opcije";
            // 
            // korisnikInformacije
            // 
            this.korisnikInformacije.Name = "korisnikInformacije";
            this.korisnikInformacije.Size = new System.Drawing.Size(134, 22);
            this.korisnikInformacije.Text = "Informacije";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.logOutToolStripMenuItem.Text = "Izloguj se";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // spratToolStripMenuItem1
            // 
            this.spratToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spratPrvi,
            this.spratDrugi});
            this.spratToolStripMenuItem1.Name = "spratToolStripMenuItem1";
            this.spratToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.spratToolStripMenuItem1.Text = "Sprat";
            // 
            // spratPrvi
            // 
            this.spratPrvi.Name = "spratPrvi";
            this.spratPrvi.Size = new System.Drawing.Size(103, 22);
            this.spratPrvi.Text = "Prvi";
            this.spratPrvi.Click += new System.EventHandler(this.spratPrvi_Click);
            // 
            // spratDrugi
            // 
            this.spratDrugi.Name = "spratDrugi";
            this.spratDrugi.Size = new System.Drawing.Size(103, 22);
            this.spratDrugi.Text = "Drugi";
            this.spratDrugi.Click += new System.EventHandler(this.spratDrugi_Click);
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijePanela});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // opcijePanela
            // 
            this.opcijePanela.Name = "opcijePanela";
            this.opcijePanela.Size = new System.Drawing.Size(146, 22);
            this.opcijePanela.Text = "Opcije panela";
            // 
            // houseLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 489);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(823, 528);
            this.MinimumSize = new System.Drawing.Size(823, 528);
            this.Name = "houseLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "houseLayout";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.houseLayout_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.houseLayout_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikOpcije;
        private System.Windows.Forms.ToolStripMenuItem korisnikInformacije;
        private System.Windows.Forms.ToolStripMenuItem spratToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spratPrvi;
        private System.Windows.Forms.ToolStripMenuItem spratDrugi;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcijePanela;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}