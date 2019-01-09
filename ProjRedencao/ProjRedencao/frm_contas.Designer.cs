namespace ProjRedencao
{
    partial class frm_contas
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
            this.trv_plano = new System.Windows.Forms.TreeView();
            this.txt_nome_conta = new System.Windows.Forms.TextBox();
            this.txt_valor_inicial = new System.Windows.Forms.TextBox();
            this.cmb_tipo_conta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_adicionar_conta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trv_plano
            // 
            this.trv_plano.Location = new System.Drawing.Point(475, 95);
            this.trv_plano.Name = "trv_plano";
            this.trv_plano.Size = new System.Drawing.Size(279, 314);
            this.trv_plano.TabIndex = 0;
            this.trv_plano.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_plano_AfterSelect);
            // 
            // txt_nome_conta
            // 
            this.txt_nome_conta.Location = new System.Drawing.Point(49, 202);
            this.txt_nome_conta.Name = "txt_nome_conta";
            this.txt_nome_conta.Size = new System.Drawing.Size(237, 21);
            this.txt_nome_conta.TabIndex = 1;
            // 
            // txt_valor_inicial
            // 
            this.txt_valor_inicial.Location = new System.Drawing.Point(49, 302);
            this.txt_valor_inicial.Name = "txt_valor_inicial";
            this.txt_valor_inicial.Size = new System.Drawing.Size(100, 21);
            this.txt_valor_inicial.TabIndex = 2;
            this.txt_valor_inicial.TextChanged += new System.EventHandler(this.txt_valor_inicial_TextChanged);
            // 
            // cmb_tipo_conta
            // 
            this.cmb_tipo_conta.FormattingEnabled = true;
            this.cmb_tipo_conta.Location = new System.Drawing.Point(49, 133);
            this.cmb_tipo_conta.Name = "cmb_tipo_conta";
            this.cmb_tipo_conta.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_conta.TabIndex = 3;
            this.cmb_tipo_conta.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_conta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label1.Location = new System.Drawing.Point(49, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.Location = new System.Drawing.Point(49, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.Location = new System.Drawing.Point(49, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Inicial";
            // 
            // btn_adicionar_conta
            // 
            this.btn_adicionar_conta.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.btn_adicionar_conta.Location = new System.Drawing.Point(207, 299);
            this.btn_adicionar_conta.Name = "btn_adicionar_conta";
            this.btn_adicionar_conta.Size = new System.Drawing.Size(79, 45);
            this.btn_adicionar_conta.TabIndex = 7;
            this.btn_adicionar_conta.Text = "Adicionar Conta";
            this.btn_adicionar_conta.UseVisualStyleBackColor = true;
            this.btn_adicionar_conta.Click += new System.EventHandler(this.btn_adicionar_conta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(742, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(772, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.25F);
            this.label4.Location = new System.Drawing.Point(280, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cadastro de Contas";
            // 
            // frm_contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_adicionar_conta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tipo_conta);
            this.Controls.Add(this.txt_valor_inicial);
            this.Controls.Add(this.txt_nome_conta);
            this.Controls.Add(this.trv_plano);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_contas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_contas";
            this.Load += new System.EventHandler(this.frm_contas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trv_plano;
        private System.Windows.Forms.TextBox txt_nome_conta;
        private System.Windows.Forms.TextBox txt_valor_inicial;
        private System.Windows.Forms.ComboBox cmb_tipo_conta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_adicionar_conta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}