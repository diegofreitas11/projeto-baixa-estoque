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
    public partial class frm_contas : Form
    {
        public frm_contas()
        {
            InitializeComponent();
        }

        object ret;
        string sql;
        private void frm_contas_Load(object sender, EventArgs e)
        {
            cmb_tipo_conta.Items.Add("Banco");
            cmb_tipo_conta.Items.Add("Estoque");

            sql = "select * from tbContas order by id desc";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);
            if (Modulo.rs.EOF == false)
            {
                Modulo.id_conta = Convert.ToInt32(Modulo.rs.Fields["id"].Value) + 1;
            }
            else
            {
                Modulo.id_conta = 1;
            }
            carrega_arvore();
        }

        private void cmb_tipo_conta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_tipo_conta.Text == "Estoque")
            {
                txt_valor_inicial.Enabled = false;
            }
            else
            {
                txt_valor_inicial.Enabled = true;
            }
            
            
        }

        private void btn_adicionar_conta_Click(object sender, EventArgs e)
        {
            double res;
            int cont = 0;
            if (cmb_tipo_conta.Text == "Estoque")
            {
                if (txt_nome_conta.Text != "")
                {
                    string sql = "insert into tbContas values ('" + Modulo.id_conta + "','Estoque','" + txt_nome_conta.Text + "','0','0')";
                    Modulo.conexao.Execute(sql, out ret);
                    MessageBox.Show("Conta adicionada com sucesso!");
                    Modulo.id_conta++;
                    txt_nome_conta.Text = "";
                    txt_valor_inicial.Text = "";
                    carrega_arvore();
                }
            }else if(cmb_tipo_conta.Text == "Banco")
            {
                if(txt_nome_conta.Text != "" && txt_valor_inicial.Text != "")
                {
                    if (double.TryParse(txt_valor_inicial.Text, out res))
                    {
                        sql = "select * from tbContas";
                        Modulo.rs = Modulo.conexao.Execute(sql, out ret);
                        while (Modulo.rs.EOF == false)
                        {
                            if(Modulo.rs.Fields["nome"].Value.ToString() == txt_nome_conta.Text && Modulo.rs.Fields["tipo"].Value.ToString() == cmb_tipo_conta.Text)              
                                cont++;

                            Modulo.rs.MoveNext();
                        }
                        if (cont == 0)
                        {
                            sql = "insert into tbContas values ('" + Modulo.id_conta + "','Banco','" + txt_nome_conta.Text + "','" + txt_valor_inicial.Text + "','0')";
                            Modulo.conexao.Execute(sql, out ret);
                            MessageBox.Show("Conta adicionada com sucesso!");
                            Modulo.id_conta++;
                            txt_nome_conta.Text = "";
                            txt_valor_inicial.Text = "";
                            carrega_arvore();
                        }
                        else
                        {
                            MessageBox.Show("Conta já existente.");
                            txt_nome_conta.Text = "";
                            txt_valor_inicial.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um valor válido");
                        txt_valor_inicial.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Preenche todos os campos");
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de conta");
            }
        }

        private void carrega_arvore()
        {
            int cont = 1;
            trv_plano.Nodes.Clear();
            TreeNode rootNode = trv_plano.Nodes.Add("1 Ativo");
            rootNode.ImageIndex = 0;

            TreeNode tipo1 = rootNode.Nodes.Add("1.1 Banco");
            tipo1.ImageIndex = 1;
            TreeNode tipo2 = rootNode.Nodes.Add("1.2 Estoque");
            tipo2.ImageIndex = 1;

            sql = "select * from tbContas where tipo='Banco'";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);

            while (Modulo.rs.EOF == false)
            {
                TreeNode child = tipo1.Nodes.Add("1.1."+ cont + " " + Modulo.rs.Fields["nome"].Value.ToString() + "...." + String.Format("{0:C}", (Convert.ToDouble(Modulo.rs.Fields["valor_entrada"].Value) - Convert.ToDouble(Modulo.rs.Fields["valor_saida"].Value))));
                child.ImageIndex = 2;
                cont++;
                Modulo.rs.MoveNext();
            }

            cont = 1;
            sql = "select * from tbContas where tipo='Estoque'";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);

            while (Modulo.rs.EOF == false)
            {
                TreeNode child = tipo2.Nodes.Add("1.2." + cont + " " + Modulo.rs.Fields["nome"].Value.ToString() + "...." + String.Format("{0:C}",(Convert.ToDouble(Modulo.rs.Fields["valor_entrada"].Value) - Convert.ToDouble(Modulo.rs.Fields["valor_saida"].Value))));
                child.ImageIndex = 2;
                cont++;
                Modulo.rs.MoveNext();
            }
        }

        private void trv_plano_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo.op = new frm_menu();
            Modulo.Abrir_opcao(this, false);
        }

        private void txt_valor_inicial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
