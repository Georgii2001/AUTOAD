
using System;
using System.Drawing;

namespace AutoAdUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bAnunt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msordonare = new System.Windows.Forms.ToolStripMenuItem();
            this.prețOrdonare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.anFabricațieOrdonare = new System.Windows.Forms.ToolStripMenuItem();
            this.mscautare = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelCautare = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TipCautare = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.PretCautare = new System.Windows.Forms.ToolStripMenuItem();
            this.mtbminPret = new System.Windows.Forms.ToolStripTextBox();
            this.mtbmaxPret = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AnFabricatieCautare = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMinAn = new System.Windows.Forms.ToolStripTextBox();
            this.tbMaxAn = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sell/ Rent ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(181)))), ((int)(((byte)(247)))));
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.Color.LightSlateGray;
            dataGridView1.Location = new System.Drawing.Point(12, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1095, 570);
            dataGridView1.TabIndex = 4;
            dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // bAnunt
            // 
            this.bAnunt.BackColor = System.Drawing.Color.LightSlateGray;
            this.bAnunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAnunt.Location = new System.Drawing.Point(952, 24);
            this.bAnunt.Name = "bAnunt";
            this.bAnunt.Size = new System.Drawing.Size(155, 42);
            this.bAnunt.TabIndex = 5;
            this.bAnunt.Text = "Adaugă anunț";
            this.bAnunt.UseVisualStyleBackColor = false;
            this.bAnunt.Click += new System.EventHandler(this.bAnunt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msordonare,
            this.mscautare});
            this.menuStrip1.Location = new System.Drawing.Point(12, 96);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(176, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msordonare
            // 
            this.msordonare.BackColor = System.Drawing.Color.LightSlateGray;
            this.msordonare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prețOrdonare,
            this.toolStripSeparator1,
            this.anFabricațieOrdonare});
            this.msordonare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msordonare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msordonare.Margin = new System.Windows.Forms.Padding(1);
            this.msordonare.Name = "msordonare";
            this.msordonare.Size = new System.Drawing.Size(89, 24);
            this.msordonare.Text = "Ordonare";
            // 
            // prețOrdonare
            // 
            this.prețOrdonare.BackColor = System.Drawing.Color.LightSlateGray;
            this.prețOrdonare.Name = "prețOrdonare";
            this.prețOrdonare.Size = new System.Drawing.Size(182, 26);
            this.prețOrdonare.Text = "Preț";
            this.prețOrdonare.Click += new System.EventHandler(this.prețOrdonare_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // anFabricațieOrdonare
            // 
            this.anFabricațieOrdonare.BackColor = System.Drawing.Color.LightSlateGray;
            this.anFabricațieOrdonare.Name = "anFabricațieOrdonare";
            this.anFabricațieOrdonare.Size = new System.Drawing.Size(182, 26);
            this.anFabricațieOrdonare.Text = "An fabricație";
            this.anFabricațieOrdonare.Click += new System.EventHandler(this.anFabricațieOrdonare_Click);
            // 
            // mscautare
            // 
            this.mscautare.BackColor = System.Drawing.Color.LightSlateGray;
            this.mscautare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModelCautare,
            this.toolStripSeparator2,
            this.TipCautare,
            this.toolStripSeparator4,
            this.PretCautare,
            this.toolStripSeparator3,
            this.AnFabricatieCautare});
            this.mscautare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mscautare.Name = "mscautare";
            this.mscautare.Size = new System.Drawing.Size(77, 26);
            this.mscautare.Text = "Cautare";
            this.mscautare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mscautare.Click += new System.EventHandler(this.mscautare_Click);
            // 
            // ModelCautare
            // 
            this.ModelCautare.BackColor = System.Drawing.Color.LightSlateGray;
            this.ModelCautare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ModelCautare.Name = "ModelCautare";
            this.ModelCautare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModelCautare.Size = new System.Drawing.Size(150, 27);
            this.ModelCautare.Text = "Model";
            this.ModelCautare.Click += new System.EventHandler(this.ModelCautare_Click_1);
            this.ModelCautare.MouseLeave += new System.EventHandler(this.ModelCautare_MouseLeave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // TipCautare
            // 
            this.TipCautare.BackColor = System.Drawing.Color.LightSlateGray;
            this.TipCautare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TipCautare.Name = "TipCautare";
            this.TipCautare.Size = new System.Drawing.Size(150, 28);
            this.TipCautare.Text = "Tip";
            this.TipCautare.SelectedIndexChanged += new System.EventHandler(this.TipCautare_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.Red;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // PretCautare
            // 
            this.PretCautare.BackColor = System.Drawing.Color.LightSlateGray;
            this.PretCautare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtbminPret,
            this.mtbmaxPret});
            this.PretCautare.Name = "PretCautare";
            this.PretCautare.Size = new System.Drawing.Size(224, 26);
            this.PretCautare.Text = "Pret";
            // 
            // mtbminPret
            // 
            this.mtbminPret.BackColor = System.Drawing.Color.LightSlateGray;
            this.mtbminPret.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mtbminPret.Name = "mtbminPret";
            this.mtbminPret.Size = new System.Drawing.Size(100, 27);
            this.mtbminPret.Text = "minim";
            this.mtbminPret.ToolTipText = "min";
            this.mtbminPret.Click += new System.EventHandler(this.mtbminPret_Click);
            this.mtbminPret.MouseLeave += new System.EventHandler(this.mtbminPret_MouseLeave);
            // 
            // mtbmaxPret
            // 
            this.mtbmaxPret.BackColor = System.Drawing.Color.LightSlateGray;
            this.mtbmaxPret.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mtbmaxPret.Name = "mtbmaxPret";
            this.mtbmaxPret.Size = new System.Drawing.Size(100, 27);
            this.mtbmaxPret.Text = "maxim";
            this.mtbmaxPret.ToolTipText = "max";
            this.mtbmaxPret.Click += new System.EventHandler(this.mtbmaxPret_Click);
            this.mtbmaxPret.MouseLeave += new System.EventHandler(this.mtbmaxPret_MouseLeave);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // AnFabricatieCautare
            // 
            this.AnFabricatieCautare.BackColor = System.Drawing.Color.LightSlateGray;
            this.AnFabricatieCautare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbMinAn,
            this.tbMaxAn});
            this.AnFabricatieCautare.Name = "AnFabricatieCautare";
            this.AnFabricatieCautare.Size = new System.Drawing.Size(224, 26);
            this.AnFabricatieCautare.Text = "An Fabricatie";
            // 
            // tbMinAn
            // 
            this.tbMinAn.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbMinAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMinAn.Name = "tbMinAn";
            this.tbMinAn.Size = new System.Drawing.Size(100, 27);
            this.tbMinAn.Text = "minim";
            this.tbMinAn.Click += new System.EventHandler(this.tbMinAn_Click);
            this.tbMinAn.MouseLeave += new System.EventHandler(this.tbMinAn_MouseLeave);
            // 
            // tbMaxAn
            // 
            this.tbMaxAn.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbMaxAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMaxAn.Name = "tbMaxAn";
            this.tbMaxAn.Size = new System.Drawing.Size(100, 27);
            this.tbMaxAn.Text = "maxim";
            this.tbMaxAn.Click += new System.EventHandler(this.tbMaxAn_Click);
            this.tbMaxAn.MouseLeave += new System.EventHandler(this.tbMaxAn_MouseLeave);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(179, 3);
            this.toolStripContainer1.Location = new System.Drawing.Point(12, 100);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(179, 28);
            this.toolStripContainer1.TabIndex = 9;
            this.toolStripContainer1.Text = "Container";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(3)))), ((int)(((byte)(143)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(-18, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1142, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;

            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(3)))), ((int)(((byte)(143)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(826, 82);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Location = new System.Drawing.Point(1, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1123, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pRefresh
            // 
            this.pRefresh.BackColor = System.Drawing.Color.SlateBlue;
            this.pRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pRefresh.Image")));
            this.pRefresh.Location = new System.Drawing.Point(195, 96);
            this.pRefresh.Name = "pRefresh";
            this.pRefresh.Size = new System.Drawing.Size(40, 31);
            this.pRefresh.TabIndex = 10;
            this.pRefresh.TabStop = false;
            this.pRefresh.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(181)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1119, 647);
            this.Controls.Add(this.pRefresh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.bAnunt);
            this.Controls.Add(dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAnunt;
        private System.Windows.Forms.ToolStripMenuItem msordonare;
        private System.Windows.Forms.ToolStripMenuItem mscautare;
        private System.Windows.Forms.ToolStripMenuItem PretCautare;
        private System.Windows.Forms.ToolStripTextBox mtbminPret;
        private System.Windows.Forms.ToolStripTextBox mtbmaxPret;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem anFabricațieOrdonare;
        private System.Windows.Forms.ToolStripMenuItem AnFabricatieCautare;
        private System.Windows.Forms.ToolStripTextBox tbMinAn;
        private System.Windows.Forms.ToolStripTextBox tbMaxAn;
        private System.Windows.Forms.ToolStripMenuItem prețOrdonare;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox ModelCautare;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox TipCautare;
        private System.Windows.Forms.PictureBox pRefresh;
        public static System.Windows.Forms.DataGridView dataGridView1;
    }
}