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
    public partial class frm_empresa : Form
    {
        public frm_empresa()
        {
            InitializeComponent();
        }
        object ret;
        string sql;
        private void btn_cadastrar_empresa_Click(object sender, EventArgs e)
        {
            if (txt_empresa_atividade.Text != "" && txt_empresa_nome.Text != "" && txt_empresa_nome.Text != "")
            {
                if (btn_cadastrar_empresa.Text == "Editar")
                {
                    sql = "delete * from tbEmpresa";
                    Modulo.conexao.Execute(sql, out ret);
                }
                Modulo.metodo_baixa = cmb_metodo.Text;
                sql = "insert into tbEmpresa values ('"+ txt_empresa_nome.Text + "','" + txt_cnpj.Text + "','"+ txt_empresa_atividade.Text +"','" + cmb_metodo.Text + "')";
                Modulo.conexao.Execute(sql, out ret, 0);
                MessageBox.Show("Dados inseridos");

                if (btn_cadastrar_empresa.Text != "Editar")
                {
                    frm_admin frm_Admin = new frm_admin();
                    frm_Admin.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
            
        }

        private void frm_empresa_Load(object sender, EventArgs e)
        {
            if (Modulo.trava == false)
            {
                sql = "select * from tbEmpresa";
                Modulo.rs = Modulo.conexao.Execute(sql, out ret);

                txt_empresa_nome.Text = Modulo.rs.Fields["nome"].Value.ToString();
                txt_empresa_atividade.Text = Modulo.rs.Fields["atividade"].Value.ToString();
                txt_cnpj.Text = Modulo.rs.Fields["cnpj"].Value.ToString();
                cmb_metodo.Text = Modulo.metodo_baixa;
                cmb_metodo.Enabled = false;
                btn_cadastrar_empresa.Text = "Editar";
                btn_voltar.Enabled = true;
            }
            else
            {
                cmb_metodo.Items.Add("PEPS");
                cmb_metodo.Items.Add("UEPS");
                cmb_metodo.Items.Add("Média Ponderada");
            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (Modulo.trava == false)
            {
                Modulo.op = new frm_menu();
            }
            else
            {
                Modulo.op = new Form1();
            }

            Modulo.Abrir_opcao(this, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Modulo.trava == false)
            {
                Modulo.op = new frm_menu();
            }
            else
            {
                Modulo.op = new Form1();
            }

            Modulo.Abrir_opcao(this, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
