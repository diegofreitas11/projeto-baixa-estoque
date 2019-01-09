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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        //string nivel;
        object ret;

        public static void Thread()
        {
            Application.Run(Modulo.op);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_login.Text !="" && txt_senha.Text != "")
            {
                string sql = "select * from tbUsuarios where login ='"+ txt_login.Text +"' and senha='" + txt_senha.Text + "'";
                Modulo.rs = Modulo.conexao.Execute(sql, out ret);

                if (Modulo.rs.EOF == false)
                {
                    MessageBox.Show("Login realizado com sucesso");
                    Modulo.nivel = Modulo.rs.Fields["Tipo"].Value.ToString();
                    txt_login.Text = "";
                    txt_senha.Text = "";
                    Modulo.op = new frm_menu();
                    Modulo.Abrir_opcao(this, false);
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                    txt_login.Text = "";
                    txt_senha.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            
        }

        private void cbx_visualizar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_visualizar.Checked == false)
            {
                txt_senha.PasswordChar = Convert.ToChar("*");
            }
            else
            {
                txt_senha.PasswordChar = Convert.ToChar("\0");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo.op = new Form1();
            Modulo.Abrir_opcao(this, false);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
