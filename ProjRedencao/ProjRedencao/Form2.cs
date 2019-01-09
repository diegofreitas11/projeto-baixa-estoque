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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        object ret;
        string sql;
        

        public static void Thread()
        {
            Application.Run(Modulo.op);
        }

        private void btn_relatorios_Click(object sender, EventArgs e)
        {
            Modulo.op = new frm_relat();
            Modulo.Abrir_opcao(this, false);
        }

        private void btn_addusuario_Click(object sender, EventArgs e)
        {
            Modulo.trava = false;
            Modulo.op = new frm_admin();
            Modulo.Abrir_opcao(this, false);

        }
        
        private void frm_menu_Load(object sender, EventArgs e)
        {
            if (Modulo.nivel == "Funcionário")
            {
                btn_addusuario.Enabled = false;
                btn_config.Enabled = false;
            }

            sql = "select * from tbEmpresa";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);
            Modulo.metodo_baixa = Modulo.rs.Fields["metodo"].Value.ToString();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            Modulo.trava = false;
            Modulo.op = new frm_empresa();
            Modulo.Abrir_opcao(this, false);


            //string sql = "select * from tbEmpresa";

            
        }

        private void btn_deslogar_Click(object sender, EventArgs e)
        {
            Modulo.op = new frm_login();
            Modulo.Abrir_opcao(this, false);

        }

        private void btn_contas_Click(object sender, EventArgs e)
        {
            Modulo.op = new frm_contas();
            Modulo.Abrir_opcao(this, false);

        }

        private void btn_lancamentos_Click(object sender, EventArgs e)
        {
            Modulo.op = new frm_lancamentos();
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Thread));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo.op = new frm_login();
            Modulo.Abrir_opcao(this, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente encerrar o programa?", "Aviso", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
