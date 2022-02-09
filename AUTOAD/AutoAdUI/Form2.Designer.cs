
namespace AutoAdUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            cbTip = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.rtbDescriere = new System.Windows.Forms.RichTextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbAnFabricatie = new System.Windows.Forms.TextBox();
            this.tbCombustibil = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lDescriere = new System.Windows.Forms.Label();
            this.lCombustibil = new System.Windows.Forms.Label();
            this.lAnFabricatie = new System.Windows.Forms.Label();
            this.lPret = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lTip = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lPoza = new System.Windows.Forms.Label();
            this.bBrowser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPoze = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sell/ Rent ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(3)))), ((int)(((byte)(143)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(-12, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(844, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(227, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 66;
            this.label2.Text = "Adaugă anunț:";
            // 
            // cbTip
            // 
            cbTip.FormattingEnabled = true;
            cbTip.Location = new System.Drawing.Point(308, 172);
            cbTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbTip.Name = "cbTip";
            cbTip.Size = new System.Drawing.Size(121, 24);
            cbTip.TabIndex = 65;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.bAdd.Location = new System.Drawing.Point(256, 545);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(102, 49);
            this.bAdd.TabIndex = 62;
            this.bAdd.Text = "Adaugă";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // rtbDescriere
            // 
            this.rtbDescriere.Location = new System.Drawing.Point(192, 423);
            this.rtbDescriere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDescriere.Name = "rtbDescriere";
            this.rtbDescriere.Size = new System.Drawing.Size(237, 90);
            this.rtbDescriere.TabIndex = 59;
            this.rtbDescriere.Text = "";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(308, 201);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(120, 22);
            this.tbMarca.TabIndex = 58;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(308, 228);
            this.tbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(120, 22);
            this.tbModel.TabIndex = 57;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(308, 256);
            this.tbPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(120, 22);
            this.tbPret.TabIndex = 56;
            this.tbPret.Validated += new System.EventHandler(this.tbPret_Validated);
            // 
            // tbAnFabricatie
            // 
            this.tbAnFabricatie.Location = new System.Drawing.Point(308, 284);
            this.tbAnFabricatie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnFabricatie.Name = "tbAnFabricatie";
            this.tbAnFabricatie.Size = new System.Drawing.Size(120, 22);
            this.tbAnFabricatie.TabIndex = 55;
            this.tbAnFabricatie.Validated += new System.EventHandler(this.tbAnFabricatie_Validated);
            // 
            // tbCombustibil
            // 
            this.tbCombustibil.Location = new System.Drawing.Point(308, 313);
            this.tbCombustibil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCombustibil.Name = "tbCombustibil";
            this.tbCombustibil.Size = new System.Drawing.Size(120, 22);
            this.tbCombustibil.TabIndex = 54;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(308, 144);
            this.tbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(120, 22);
            this.tbId.TabIndex = 53;
            // 
            // lDescriere
            // 
            this.lDescriere.AutoSize = true;
            this.lDescriere.Location = new System.Drawing.Point(189, 404);
            this.lDescriere.Name = "lDescriere";
            this.lDescriere.Size = new System.Drawing.Size(69, 17);
            this.lDescriere.TabIndex = 51;
            this.lDescriere.Text = "Descriere";
            // 
            // lCombustibil
            // 
            this.lCombustibil.AutoSize = true;
            this.lCombustibil.Location = new System.Drawing.Point(190, 315);
            this.lCombustibil.Name = "lCombustibil";
            this.lCombustibil.Size = new System.Drawing.Size(80, 17);
            this.lCombustibil.TabIndex = 50;
            this.lCombustibil.Text = "Combustibil";
            // 
            // lAnFabricatie
            // 
            this.lAnFabricatie.AutoSize = true;
            this.lAnFabricatie.Location = new System.Drawing.Point(189, 287);
            this.lAnFabricatie.Name = "lAnFabricatie";
            this.lAnFabricatie.Size = new System.Drawing.Size(91, 17);
            this.lAnFabricatie.TabIndex = 49;
            this.lAnFabricatie.Text = "An Fabricatie";
            // 
            // lPret
            // 
            this.lPret.AutoSize = true;
            this.lPret.Location = new System.Drawing.Point(190, 258);
            this.lPret.Name = "lPret";
            this.lPret.Size = new System.Drawing.Size(34, 17);
            this.lPret.TabIndex = 48;
            this.lPret.Text = "Pret";
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Location = new System.Drawing.Point(190, 231);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(46, 17);
            this.lModel.TabIndex = 47;
            this.lModel.Text = "Model";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(190, 203);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(47, 17);
            this.lMarca.TabIndex = 46;
            this.lMarca.Text = "Marca";
            // 
            // lTip
            // 
            this.lTip.AutoSize = true;
            this.lTip.Location = new System.Drawing.Point(190, 175);
            this.lTip.Name = "lTip";
            this.lTip.Size = new System.Drawing.Size(28, 17);
            this.lTip.TabIndex = 45;
            this.lTip.Text = "Tip";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lId.Location = new System.Drawing.Point(190, 148);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 17);
            this.lId.TabIndex = 44;
            this.lId.Text = "Id";
            // 
            // lPoza
            // 
            this.lPoza.AutoSize = true;
            this.lPoza.Location = new System.Drawing.Point(190, 345);
            this.lPoza.Name = "lPoza";
            this.lPoza.Size = new System.Drawing.Size(80, 17);
            this.lPoza.TabIndex = 67;
            this.lPoza.Text = "Alege Poza";
            // 
            // bBrowser
            // 
            this.bBrowser.BackColor = System.Drawing.Color.White;
            this.bBrowser.Location = new System.Drawing.Point(308, 341);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(121, 23);
            this.bBrowser.TabIndex = 68;
            this.bBrowser.Text = "Browser";
            this.bBrowser.UseVisualStyleBackColor = false;
            this.bBrowser.Click += new System.EventHandler(this.bBrowser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(189, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "* toate câmpurile sunt obligatorii";
            // 
            // rbPoze
            // 
            this.rbPoze.AutoSize = true;
            this.rbPoze.Location = new System.Drawing.Point(191, 375);
            this.rbPoze.Name = "rbPoze";
            this.rbPoze.Size = new System.Drawing.Size(0, 17);
            this.rbPoze.TabIndex = 70;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(181)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(628, 653);
            this.Controls.Add(this.rbPoze);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBrowser);
            this.Controls.Add(this.lPoza);
            this.Controls.Add(this.label2);
            this.Controls.Add(cbTip);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.rtbDescriere);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbAnFabricatie);
            this.Controls.Add(this.tbCombustibil);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lDescriere);
            this.Controls.Add(this.lCombustibil);
            this.Controls.Add(this.lAnFabricatie);
            this.Controls.Add(this.lPret);
            this.Controls.Add(this.lModel);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lTip);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lDescriere;
        private System.Windows.Forms.Label lCombustibil;
        private System.Windows.Forms.Label lAnFabricatie;
        private System.Windows.Forms.Label lPret;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lTip;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lPoza;
        private System.Windows.Forms.Button bBrowser;
        private System.Windows.Forms.Label label3;
        public static  System.Windows.Forms.ComboBox cbTip;
        public System.Windows.Forms.RichTextBox rtbDescriere;
        public System.Windows.Forms.TextBox tbMarca;
        public System.Windows.Forms.TextBox tbModel;
        public System.Windows.Forms.TextBox tbPret;
        public System.Windows.Forms.TextBox tbAnFabricatie;
        public System.Windows.Forms.TextBox tbCombustibil;
        public System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label rbPoze;
    }
}