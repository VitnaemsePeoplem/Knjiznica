
namespace Knjiznicaaaaa.Forme
{
    partial class frmKnjiznica
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
            this.lbPosudbe = new System.Windows.Forms.ListBox();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uceniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPosudbe
            // 
            this.lbPosudbe.FormattingEnabled = true;
            this.lbPosudbe.Location = new System.Drawing.Point(43, 89);
            this.lbPosudbe.Name = "lbPosudbe";
            this.lbPosudbe.Size = new System.Drawing.Size(379, 264);
            this.lbPosudbe.TabIndex = 0;
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(474, 89);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(109, 39);
            this.btnPosudi.TabIndex = 1;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(474, 198);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(109, 39);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(474, 314);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(109, 39);
            this.btnVrati.TabIndex = 3;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posuđene knjige";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uceniciToolStripMenuItem,
            this.knjigeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // uceniciToolStripMenuItem
            // 
            this.uceniciToolStripMenuItem.Name = "uceniciToolStripMenuItem";
            this.uceniciToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.uceniciToolStripMenuItem.Text = "Ucenici";
            this.uceniciToolStripMenuItem.Click += new System.EventHandler(this.uceniciToolStripMenuItem_Click);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click);
            // 
            // frmKnjiznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.lbPosudbe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmKnjiznica";
            this.Text = "Knjižnica";
            this.Load += new System.EventHandler(this.frmKnjiznica_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPosudbe;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uceniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
    }
}