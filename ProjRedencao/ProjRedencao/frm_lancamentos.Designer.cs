namespace ProjRedencao
{
    partial class frm_lancamentos
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
            this.btn_compra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ctotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cvalor = new System.Windows.Forms.TextBox();
            this.num_cqtd = new System.Windows.Forms.NumericUpDown();
            this.cmb_ccredito = new System.Windows.Forms.ComboBox();
            this.cmb_cdebito = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_bvalor = new System.Windows.Forms.TextBox();
            this.num_bqtd = new System.Windows.Forms.NumericUpDown();
            this.cmb_bcredito = new System.Windows.Forms.ComboBox();
            this.cmb_bdebito = new System.Windows.Forms.ComboBox();
            this.btn_baixa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cqtd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bqtd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_compra
            // 
            this.btn_compra.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.btn_compra.Location = new System.Drawing.Point(482, 99);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(75, 23);
            this.btn_compra.TabIndex = 0;
            this.btn_compra.Text = "OK";
            this.btn_compra.UseVisualStyleBackColor = true;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ctotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_cvalor);
            this.groupBox1.Controls.Add(this.num_cqtd);
            this.groupBox1.Controls.Add(this.cmb_ccredito);
            this.groupBox1.Controls.Add(this.cmb_cdebito);
            this.groupBox1.Controls.Add(this.btn_compra);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(62, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra";
            // 
            // lbl_ctotal
            // 
            this.lbl_ctotal.AutoSize = true;
            this.lbl_ctotal.Location = new System.Drawing.Point(495, 57);
            this.lbl_ctotal.Name = "lbl_ctotal";
            this.lbl_ctotal.Size = new System.Drawing.Size(42, 17);
            this.lbl_ctotal.TabIndex = 10;
            this.lbl_ctotal.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label5.Location = new System.Drawing.Point(495, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label4.Location = new System.Drawing.Point(309, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.Location = new System.Drawing.Point(309, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Unitário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crédito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Débito";
            // 
            // txt_cvalor
            // 
            this.txt_cvalor.Location = new System.Drawing.Point(312, 102);
            this.txt_cvalor.Name = "txt_cvalor";
            this.txt_cvalor.Size = new System.Drawing.Size(120, 24);
            this.txt_cvalor.TabIndex = 4;
            this.txt_cvalor.TextChanged += new System.EventHandler(this.txt_cvalor_TextChanged);
            // 
            // num_cqtd
            // 
            this.num_cqtd.Location = new System.Drawing.Point(312, 45);
            this.num_cqtd.Name = "num_cqtd";
            this.num_cqtd.Size = new System.Drawing.Size(120, 24);
            this.num_cqtd.TabIndex = 3;
            this.num_cqtd.ValueChanged += new System.EventHandler(this.num_cqtd_ValueChanged);
            // 
            // cmb_ccredito
            // 
            this.cmb_ccredito.FormattingEnabled = true;
            this.cmb_ccredito.Location = new System.Drawing.Point(52, 102);
            this.cmb_ccredito.Name = "cmb_ccredito";
            this.cmb_ccredito.Size = new System.Drawing.Size(121, 25);
            this.cmb_ccredito.TabIndex = 2;
            this.cmb_ccredito.SelectedIndexChanged += new System.EventHandler(this.cmb_ccredito_SelectedIndexChanged);
            // 
            // cmb_cdebito
            // 
            this.cmb_cdebito.FormattingEnabled = true;
            this.cmb_cdebito.Location = new System.Drawing.Point(52, 44);
            this.cmb_cdebito.Name = "cmb_cdebito";
            this.cmb_cdebito.Size = new System.Drawing.Size(121, 25);
            this.cmb_cdebito.TabIndex = 1;
            this.cmb_cdebito.SelectedIndexChanged += new System.EventHandler(this.cmb_cdebito_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_bvalor);
            this.groupBox2.Controls.Add(this.num_bqtd);
            this.groupBox2.Controls.Add(this.cmb_bcredito);
            this.groupBox2.Controls.Add(this.cmb_bdebito);
            this.groupBox2.Controls.Add(this.btn_baixa);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(62, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baixa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Valor Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Crédito";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Débito";
            // 
            // txt_bvalor
            // 
            this.txt_bvalor.Location = new System.Drawing.Point(299, 107);
            this.txt_bvalor.Name = "txt_bvalor";
            this.txt_bvalor.Size = new System.Drawing.Size(120, 24);
            this.txt_bvalor.TabIndex = 15;
            // 
            // num_bqtd
            // 
            this.num_bqtd.Location = new System.Drawing.Point(299, 50);
            this.num_bqtd.Name = "num_bqtd";
            this.num_bqtd.Size = new System.Drawing.Size(120, 24);
            this.num_bqtd.TabIndex = 14;
            this.num_bqtd.ValueChanged += new System.EventHandler(this.num_bqtd_ValueChanged);
            // 
            // cmb_bcredito
            // 
            this.cmb_bcredito.FormattingEnabled = true;
            this.cmb_bcredito.Location = new System.Drawing.Point(39, 107);
            this.cmb_bcredito.Name = "cmb_bcredito";
            this.cmb_bcredito.Size = new System.Drawing.Size(121, 25);
            this.cmb_bcredito.TabIndex = 13;
            this.cmb_bcredito.SelectedIndexChanged += new System.EventHandler(this.cmb_bcredito_SelectedIndexChanged);
            // 
            // cmb_bdebito
            // 
            this.cmb_bdebito.FormattingEnabled = true;
            this.cmb_bdebito.Location = new System.Drawing.Point(39, 49);
            this.cmb_bdebito.Name = "cmb_bdebito";
            this.cmb_bdebito.Size = new System.Drawing.Size(121, 25);
            this.cmb_bdebito.TabIndex = 12;
            this.cmb_bdebito.SelectedIndexChanged += new System.EventHandler(this.cmb_bdebito_SelectedIndexChanged);
            // 
            // btn_baixa
            // 
            this.btn_baixa.Location = new System.Drawing.Point(478, 78);
            this.btn_baixa.Name = "btn_baixa";
            this.btn_baixa.Size = new System.Drawing.Size(75, 23);
            this.btn_baixa.TabIndex = 11;
            this.btn_baixa.Text = "OK";
            this.btn_baixa.UseVisualStyleBackColor = true;
            this.btn_baixa.Click += new System.EventHandler(this.btn_baixa_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(636, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(666, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.25F);
            this.label6.Location = new System.Drawing.Point(249, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lançamentos";
            // 
            // frm_lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_lancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_lancamentos";
            this.Load += new System.EventHandler(this.frm_lancamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cqtd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bqtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ctotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cvalor;
        private System.Windows.Forms.NumericUpDown num_cqtd;
        private System.Windows.Forms.ComboBox cmb_ccredito;
        private System.Windows.Forms.ComboBox cmb_cdebito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_bvalor;
        private System.Windows.Forms.NumericUpDown num_bqtd;
        private System.Windows.Forms.ComboBox cmb_bcredito;
        private System.Windows.Forms.ComboBox cmb_bdebito;
        private System.Windows.Forms.Button btn_baixa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}