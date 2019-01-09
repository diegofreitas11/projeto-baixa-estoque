namespace ProjRedencao
{
    partial class frm_admin
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
            this.btn_cadastrar_admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_admin_nome = new System.Windows.Forms.TextBox();
            this.txt_admin_cpf = new System.Windows.Forms.TextBox();
            this.txt_admin_login = new System.Windows.Forms.TextBox();
            this.txt_admin_senha = new System.Windows.Forms.TextBox();
            this.txt_admin_rsenha = new System.Windows.Forms.TextBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadastrar_admin
            // 
            this.btn_cadastrar_admin.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.btn_cadastrar_admin.Location = new System.Drawing.Point(145, 381);
            this.btn_cadastrar_admin.Name = "btn_cadastrar_admin";
            this.btn_cadastrar_admin.Size = new System.Drawing.Size(223, 34);
            this.btn_cadastrar_admin.TabIndex = 0;
            this.btn_cadastrar_admin.Text = "Cadastrar";
            this.btn_cadastrar_admin.UseVisualStyleBackColor = true;
            this.btn_cadastrar_admin.Click += new System.EventHandler(this.btn_cadastrar_admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label1.Location = new System.Drawing.Point(74, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.Location = new System.Drawing.Point(384, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.Location = new System.Drawing.Point(74, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label4.Location = new System.Drawing.Point(74, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label5.Location = new System.Drawing.Point(282, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Repetir senha";
            // 
            // txt_admin_nome
            // 
            this.txt_admin_nome.Location = new System.Drawing.Point(77, 167);
            this.txt_admin_nome.Name = "txt_admin_nome";
            this.txt_admin_nome.Size = new System.Drawing.Size(240, 21);
            this.txt_admin_nome.TabIndex = 6;
            // 
            // txt_admin_cpf
            // 
            this.txt_admin_cpf.Location = new System.Drawing.Point(387, 166);
            this.txt_admin_cpf.Name = "txt_admin_cpf";
            this.txt_admin_cpf.Size = new System.Drawing.Size(100, 21);
            this.txt_admin_cpf.TabIndex = 8;
            // 
            // txt_admin_login
            // 
            this.txt_admin_login.Location = new System.Drawing.Point(77, 245);
            this.txt_admin_login.Name = "txt_admin_login";
            this.txt_admin_login.Size = new System.Drawing.Size(191, 21);
            this.txt_admin_login.TabIndex = 9;
            // 
            // txt_admin_senha
            // 
            this.txt_admin_senha.Location = new System.Drawing.Point(77, 315);
            this.txt_admin_senha.Name = "txt_admin_senha";
            this.txt_admin_senha.Size = new System.Drawing.Size(100, 21);
            this.txt_admin_senha.TabIndex = 10;
            // 
            // txt_admin_rsenha
            // 
            this.txt_admin_rsenha.Location = new System.Drawing.Point(276, 315);
            this.txt_admin_rsenha.Name = "txt_admin_rsenha";
            this.txt_admin_rsenha.Size = new System.Drawing.Size(100, 21);
            this.txt_admin_rsenha.TabIndex = 11;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(387, 243);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(100, 21);
            this.cmb_tipo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label6.Location = new System.Drawing.Point(384, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(489, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 15;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(519, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.25F);
            this.label7.Location = new System.Drawing.Point(173, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cadastro de Usuários";
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_admin_rsenha);
            this.Controls.Add(this.txt_admin_senha);
            this.Controls.Add(this.txt_admin_login);
            this.Controls.Add(this.txt_admin_cpf);
            this.Controls.Add(this.txt_admin_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastrar_admin);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_admin_nome;
        private System.Windows.Forms.TextBox txt_admin_cpf;
        private System.Windows.Forms.TextBox txt_admin_login;
        private System.Windows.Forms.TextBox txt_admin_senha;
        private System.Windows.Forms.TextBox txt_admin_rsenha;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}