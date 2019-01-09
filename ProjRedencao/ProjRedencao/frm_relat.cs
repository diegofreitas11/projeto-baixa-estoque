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
    public partial class frm_relat : Form
    {
        public frm_relat()
        {
            InitializeComponent();
        }

        string sql;
        object ret;

        private void frm_relat_Load(object sender, EventArgs e)
        {
            sql = "select * from tbContas where tipo = 'estoque'";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);

            while(Modulo.rs.EOF == false)
            {
                cmb_relat_estoque.Items.Add(Modulo.rs.Fields["nome"].Value.ToString());
                cmb_simul_estoque.Items.Add(Modulo.rs.Fields["nome"].Value.ToString());
                Modulo.rs.MoveNext();
            }

            if(Modulo.metodo_baixa == "UEPS")
            {
                cmb_simul_metodo.Items.Add("PEPS");
                cmb_simul_metodo.Items.Add("Média Ponderada");

            }else if(Modulo.metodo_baixa == "PEPS")
            {
                cmb_simul_metodo.Items.Add("UEPS");
                cmb_simul_metodo.Items.Add("Média Ponderada");
            }
            else
            {
                cmb_simul_metodo.Items.Add("PEPS");
                cmb_simul_metodo.Items.Add("UEPS");
            }
        }

        private void carrega_grid(string estoque, string metodo, bool relatorio_real)
        {
            object ret;
            string valor_unit = " - ";
            DataGridView dgv;
            double saldo_qtd = 0, saldo_valor = 0;
            string sql = "select * from tbLancamentos where débito='" + estoque + "' or crédito='" + estoque + "'";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);

            if (relatorio_real)
            {
                dgv = dgv_relatorio;
            }
            else
            {
                dgv = dgv_simulacao;
            }

            dgv.Rows.Clear();
            while (Modulo.rs.EOF == false)
            {
                if (metodo == "Média Ponderada")
                {
                    valor_unit = String.Format("{0:C}", (Convert.ToDouble(Modulo.rs.Fields["valor_total"].Value) / Convert.ToDouble(Modulo.rs.Fields["quantidade"].Value)));
                }

                if (Modulo.rs.Fields["débito"].Value.ToString() == estoque)
                {
                    saldo_qtd += Convert.ToDouble(Modulo.rs.Fields["quantidade"].Value);
                    saldo_valor += Convert.ToDouble(Modulo.rs.Fields["valor_total"].Value);
                    dgv.Rows.Add(Modulo.rs.Fields["id"].Value.ToString(), Modulo.rs.Fields["quantidade"].Value.ToString(), String.Format("{0:C}", Modulo.rs.Fields["valor_unitario"].Value), String.Format("{0:C}", Modulo.rs.Fields["valor_total"].Value), "", "", "",saldo_qtd, String.Format("{0:C}", saldo_valor /saldo_qtd), String.Format("{0:C}",saldo_valor));
                }
                else
                {
                    saldo_qtd -= Convert.ToDouble(Modulo.rs.Fields["quantidade"].Value);
                    saldo_valor -= Convert.ToDouble(Modulo.rs.Fields["valor_total"].Value);
                    dgv.Rows.Add(Modulo.rs.Fields["id"].Value.ToString(),"", "", "",Modulo.rs.Fields["quantidade"].Value.ToString(), String.Format("{0:C}",valor_unit) , String.Format("{0:C}", Modulo.rs.Fields["valor_total"].Value),saldo_qtd, String.Format("{0:C}", saldo_valor / saldo_qtd), String.Format("{0:C}",saldo_valor));
                }
                Modulo.rs.MoveNext();
            }

        }

        private void btn_relat_Click(object sender, EventArgs e)
        {
            if(cmb_relat_estoque.Text != "")
            {
                atualiza_metodo(cmb_relat_estoque.Text, Modulo.metodo_baixa);
                carrega_grid(cmb_relat_estoque.Text, Modulo.metodo_baixa, true);
            }
            else
            {
                MessageBox.Show("Selecione um tipo de estoque.");
            }
        }

        private void btn_simulacao_Click(object sender, EventArgs e)
        {
            if(cmb_simul_estoque.Text != "" && cmb_simul_metodo.Text != "")
            {
               
                atualiza_metodo(cmb_simul_estoque.Text, cmb_simul_metodo.Text);
                carrega_grid(cmb_simul_estoque.Text, cmb_simul_metodo.Text, false);
            }
            else
            {
                MessageBox.Show("Escolha o estoque e o método de simulação");
            }
        }

        private void atualiza_metodo(string estoque, string metodo)
        {
            double novo_valor;
            sql = "select * from tbLancamentos where débito='" + estoque + "' or crédito = '" + estoque + "'";
            Modulo.rx = Modulo.conexao.Execute(sql, out ret);

            while(Modulo.rx.EOF == false)
            { 

                if (Modulo.rx.Fields["crédito"].Value.ToString() == estoque)
                {
                    if (metodo == "Média Ponderada")
                    {
                        novo_valor = Modulo.baixa_media(estoque, Convert.ToInt32(Modulo.rx.Fields["quantidade"].Value), Convert.ToInt32(Modulo.rx.Fields["id"].Value));
                    }
                    else
                    {
                        novo_valor = Modulo.baixa_estoque(estoque, Convert.ToInt32(Modulo.rx.Fields["quantidade"].Value), metodo, Convert.ToInt32(Modulo.rx.Fields["id"].Value));
                    }

                    sql = "update tbLancamentos set valor_total ='" + novo_valor + "' where id=" + Convert.ToInt32(Modulo.rx.Fields["id"].Value) + "";
                    Modulo.conexao.Execute(sql, out ret);

                }
                Modulo.rx.MoveNext();
            }
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
    }
}
