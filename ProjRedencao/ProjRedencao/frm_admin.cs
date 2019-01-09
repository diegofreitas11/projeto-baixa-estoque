using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjRedencao
{
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        object ret;

        private void btn_cadastrar_admin_Click(object sender, EventArgs e)
        {
            if (txt_admin_cpf.Text != "" && txt_admin_login.Text != "" && txt_admin_nome.Text != "" && txt_admin_senha.Text !="" && txt_admin_rsenha.Text != "")
            {
                if (txt_admin_senha.Text == txt_admin_rsenha.Text)
                {
                    string sql = "insert into tbUsuarios values ('" + txt_admin_cpf.Text + "','" + txt_admin_nome.Text + "','" + txt_admin_login.Text + "','" + txt_admin_senha.Text + "','" + cmb_tipo.Text + "')";
                    Modulo.conexao.Execute(sql, out ret);
                    MessageBox.Show("Dados inseridos com sucesso");
                    if (cmb_tipo.Enabled == false)
                    {
                        frm_login frm_Login = new frm_login();
                        frm_Login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Senhas divergentes.");
                }
            }
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            cmb_tipo.Items.Add("ADM");
            cmb_tipo.Items.Add("Funcionário");

            if (Modulo.trava)
            {
                cmb_tipo.Text = "ADM";
                cmb_tipo.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbUsuarios where tipo='ADM'";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);
            if (Modulo.rs.EOF == false)
            {
                Modulo.op = new frm_menu();
                Modulo.Abrir_opcao(this, false);
            }
            else
            {
                Modulo.op = new Form1();
                Modulo.Abrir_opcao(this, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_limpar_admin_Click(object sender, EventArgs e)
        {

        }
    }
}
