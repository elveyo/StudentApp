namespace DLWMS.WinForms.IB220246
{
    partial class frmPretraga
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPredmet = new System.Windows.Forms.TextBox();
            this.dgvStudentPredmeti = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOd = new System.Windows.Forms.TextBox();
            this.tbDo = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentPredmeti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta:";
            // 
            // tbPredmet
            // 
            this.tbPredmet.Location = new System.Drawing.Point(181, 13);
            this.tbPredmet.Name = "tbPredmet";
            this.tbPredmet.Size = new System.Drawing.Size(584, 22);
            this.tbPredmet.TabIndex = 1;
            this.tbPredmet.TextChanged += new System.EventHandler(this.tbPredmet_TextChanged);
            // 
            // dgvStudentPredmeti
            // 
            this.dgvStudentPredmeti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvStudentPredmeti.Location = new System.Drawing.Point(12, 60);
            this.dgvStudentPredmeti.Name = "dgvStudentPredmeti";
            this.dgvStudentPredmeti.RowHeadersWidth = 51;
            this.dgvStudentPredmeti.RowTemplate.Height = 24;
            this.dgvStudentPredmeti.Size = new System.Drawing.Size(750, 242);
            this.dgvStudentPredmeti.TabIndex = 2;
            this.dgvStudentPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentPredmeti_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student";
            this.Column1.HeaderText = "Ime prezime";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Predmet";
            this.Column2.HeaderText = "Predmet";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ocjena";
            this.Column3.HeaderText = "Ocjena";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DatumPolaganja";
            this.Column4.HeaderText = "Datum polaganja";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Brisi Predmet";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Text = "Brisi";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Slike";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Text = "Slike";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(664, 321);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(98, 44);
            this.btnPrintaj.TabIndex = 3;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSuma);
            this.groupBox1.Controls.Add(this.tbDo);
            this.groupBox1.Controls.Add(this.tbOd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sumiraj brojeve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Do:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sumiraj =>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suma:";
            // 
            // tbOd
            // 
            this.tbOd.Location = new System.Drawing.Point(9, 58);
            this.tbOd.Name = "tbOd";
            this.tbOd.Size = new System.Drawing.Size(100, 22);
            this.tbOd.TabIndex = 4;
            // 
            // tbDo
            // 
            this.tbDo.Location = new System.Drawing.Point(166, 58);
            this.tbDo.Name = "tbDo";
            this.tbDo.Size = new System.Drawing.Size(100, 22);
            this.tbDo.TabIndex = 5;
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(425, 57);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 22);
            this.tbSuma.TabIndex = 6;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvStudentPredmeti);
            this.Controls.Add(this.tbPredmet);
            this.Controls.Add(this.label1);
            this.Name = "frmPretraga";
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentPredmeti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPredmet;
        private System.Windows.Forms.DataGridView dgvStudentPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.TextBox tbDo;
        private System.Windows.Forms.TextBox tbOd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}