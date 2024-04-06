namespace DLWMS.WinForms.IB220246
{
    partial class frmStudentSlike
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbOdabranaSlika = new System.Windows.Forms.PictureBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbTrenutnaSlika = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblBrojSlike = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errOpis = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSlika = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabranaSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrenutnaSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOpis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // pbOdabranaSlika
            // 
            this.pbOdabranaSlika.Location = new System.Drawing.Point(15, 50);
            this.pbOdabranaSlika.Name = "pbOdabranaSlika";
            this.pbOdabranaSlika.Size = new System.Drawing.Size(116, 140);
            this.pbOdabranaSlika.TabIndex = 2;
            this.pbOdabranaSlika.TabStop = false;
            this.pbOdabranaSlika.DoubleClick += new System.EventHandler(this.pbOdabranaSlika_DoubleClick);
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(264, 50);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(482, 101);
            this.rtbOpis.TabIndex = 3;
            this.rtbOpis.Text = "";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(648, 158);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(98, 23);
            this.btnDodajSliku.TabIndex = 4;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pregled slike:";
            // 
            // pbTrenutnaSlika
            // 
            this.pbTrenutnaSlika.Location = new System.Drawing.Point(287, 288);
            this.pbTrenutnaSlika.Name = "pbTrenutnaSlika";
            this.pbTrenutnaSlika.Size = new System.Drawing.Size(246, 245);
            this.pbTrenutnaSlika.TabIndex = 6;
            this.pbTrenutnaSlika.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(615, 399);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "=>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(96, 399);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "<=";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(384, 608);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(44, 16);
            this.lblOpis.TabIndex = 9;
            this.lblOpis.Text = "label4";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(369, 552);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(44, 16);
            this.lblDatum.TabIndex = 10;
            this.lblDatum.Text = "label4";
            // 
            // lblBrojSlike
            // 
            this.lblBrojSlike.AutoSize = true;
            this.lblBrojSlike.Location = new System.Drawing.Point(369, 248);
            this.lblBrojSlike.Name = "lblBrojSlike";
            this.lblBrojSlike.Size = new System.Drawing.Size(58, 16);
            this.lblBrojSlike.TabIndex = 11;
            this.lblBrojSlike.Text = "Slika 2/2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errOpis
            // 
            this.errOpis.ContainerControl = this;
            // 
            // errSlika
            // 
            this.errSlika.ContainerControl = this;
            // 
            // frmStudentSlike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.lblBrojSlike);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.pbTrenutnaSlika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.pbOdabranaSlika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentSlike";
            this.Text = "frmStudentSlike";
            this.Load += new System.EventHandler(this.frmStudentSlike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabranaSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrenutnaSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOpis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbOdabranaSlika;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbTrenutnaSlika;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblBrojSlike;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errOpis;
        private System.Windows.Forms.ErrorProvider errSlika;
    }
}