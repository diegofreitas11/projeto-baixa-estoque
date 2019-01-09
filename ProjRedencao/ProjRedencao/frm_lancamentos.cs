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
    public partial class frm_lancamentos : Form
    {
        public frm_lancamentos()
        {
            InitializeComponent();
        }
        string sql;
        object ret;
        float res;        
        int id_lancamento;
        int maximo;
        double maximo_banco;

        private void frm_lancamentos_Load(object sender, EventArgs e)
        {
            num_bqtd.TextChanged += new EventHandler(num_bqtd_TextChanged);
            num_cqtd.TextChanged += new EventHandler(num_cqtd_TextChanged);


            sql = "select * from tbLancamentos order by id desc";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);

            if (Modulo.rs.EOF == false)
            {
                id_lancamento = Convert.ToInt32(Modulo.rs.Fields["id"].Value) + 1;
            }
            else
            {
                id_lancamento = 1;
            }

            sql = "select * from tbContas";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);
            while (Modulo.rs.EOF == false)
            {
                if (Modulo.rs.Fields["tipo"].Value.ToString() == "Estoque")
                {
                    cmb_cdebito.Items.Add(Modulo.rs.Fields["nome"].Value.ToString());
                    cmb_bcredito.Items.Add(Modulo.rs.Fields["nome"].Value.ToString());
                }
                else
                {
                    cmb_ccredito.Items.Add(Modulo.rs.Fields["nome"].Value.ToString());
                    cmb_bdebito.Items.Add(Modulo.rs.Fields["nome"].Value.ToString());
                }
                Modulo.rs.MoveNext();
            }
            num_cqtd.Enabled = false;
            num_bqtd.Enabled = false;
            txt_bvalor.Enabled = false;
            txt_cvalor.Enabled = false;
            lbl_ctotal.Text = "";
        }

        private void cmb_cdebito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_ccredito.Text != "")
            {
                txt_cvalor.Enabled = true;
                num_cqtd.Enabled = true;
            }
        }

        private void cmb_ccredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_cdebito.Text != "")
            {
                txt_cvalor.Enabled = true;
                num_cqtd.Enabled = true;
            }

            sql = "select * from tbContas where nome='" + cmb_ccredito.Text + "'";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);

            maximo_banco = Convert.ToDouble(Modulo.rs.Fields["valor_entrada"].Value) - Convert.ToDouble(Modulo.rs.Fields["valor_saida"].Value);
        }

        private void cmb_bdebito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_bcredito.Text != "")
            {
                num_bqtd.Enabled = true;
            }
        }

        private void cmb_bcredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_bdebito.Text != "")
            {
                num_bqtd.Enabled = true;
            }

            maximo = 0;

            sql = "select * from tbLancamentos where débito ='" + cmb_bcredito.Text + "' or crédito = '" + cmb_bcredito.Text + "'";
            Modulo.rs = Modulo.conexao.Execute(sql, out ret);

            while (Modulo.rs.EOF == false)
            {
                if (Modulo.rs.Fields["débito"].Value.ToString() == cmb_bcredito.Text)
                {
                    maximo += Convert.ToInt32(Modulo.rs.Fields["quantidade"].Value);
                }
                else
                {
                    maximo -= Convert.ToInt32(Modulo.rs.Fields["quantidade"].Value);
                }
                Modulo.rs.MoveNext();
            }

            if(maximo == 0)
            {
                MessageBox.Show("Estoque inteiramente baixado.");
                cmb_bcredito.Text = "";
            }

            num_bqtd.Maximum = maximo;
            
        }

        private void num_cqtd_ValueChanged(object sender, EventArgs e)
        {
            if (txt_cvalor.Text != "" && txt_cvalor.Text != "0")
            {
                lbl_ctotal.Text = String.Format("{0:C}", (Convert.ToDouble(txt_cvalor.Text) * Convert.ToDouble(num_cqtd.Value)));
            }
        }

        private void num_cqtd_TextChanged(object sender, EventArgs e)
        {
            if (num_cqtd.Text != "" && txt_cvalor.Text != "")
            {               
                lbl_ctotal.Text = String.Format("{0:C}", (Convert.ToDouble(txt_cvalor.Text) * Convert.ToDouble(num_cqtd.Value))); 
            }
            num_cqtd.Value = Convert.ToInt32(num_cqtd.Value);
            
        }

        private void txt_cvalor_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txt_cvalor.Text, out res))
            {
                if (num_cqtd.Value != 0)
                {
                    lbl_ctotal.Text = String.Format("{0:C}",(Convert.ToDouble(txt_cvalor.Text) * Convert.ToDouble(num_cqtd.Value)));
                }
            }
            else
            {
                txt_cvalor.Text = "";
            }
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            if(cmb_ccredito.Text != "" && cmb_cdebito.Text != "" && txt_cvalor.Text != "" && num_cqtd.Value != 0)
            {
                sql = "select * from tbContas where nome='" + cmb_ccredito.Text + "'";
                Modulo.rs = Modulo.conexao.Execute(sql, out ret);
                maximo_banco = Convert.ToDouble(Modulo.rs.Fields["valor_entrada"].Value) - Convert.ToDouble(Modulo.rs.Fields["valor_saida"].Value);
                
                if (maximo_banco >= Convert.ToDouble(lbl_ctotal.Text))
                { 
                    sql = "insert into tbLancamentos values ('" + id_lancamento + "','" + cmb_cdebito.Text + "','" + cmb_ccredito.Text + "','" + Convert.ToDouble(txt_cvalor.Text) + "','" + num_cqtd.Value + "','" + Convert.ToDouble(lbl_ctotal.Text) + "','" + DateTime.Today + "')";
                    Modulo.conexao.Execute(sql, out ret);

                    sql = "select * from tbContas where nome='" + cmb_cdebito.Text + "'";
                    Modulo.rs = Modulo.conexao.Execute(sql, out ret);

                    sql = "update tbContas set valor_entrada='" + (Convert.ToDouble(Modulo.rs.Fields["valor_entrada"].Value) + Convert.ToDouble(lbl_ctotal.Text)) + "' where nome='" + cmb_cdebito.Text + "'";
                    Modulo.conexao.Execute(sql, out ret);

                    sql = "select * from tbContas where nome='" + cmb_ccredito.Text + "'";
                    Modulo.rs = Modulo.conexao.Execute(sql, out ret);

                    sql = "update tbContas set valor_saida='" + (Convert.ToDouble(Modulo.rs.Fields["valor_saida"].Value) + Convert.ToDouble(lbl_ctotal.Text)) + "' where nome='" + cmb_ccredito.Text + "'";
                    Modulo.conexao.Execute(sql, out ret);

                    MessageBox.Show("Lançamento realizado.");
                    id_lancamento++;
                    maximo += Convert.ToInt32(num_cqtd.Value);
                    num_bqtd.Maximum = maximo;
                    //txt_cvalor.Enabled = false;
                    txt_cvalor.Text = "";
                    num_cqtd.Value = 0;
                    lbl_ctotal.Text = "";

                }
                else
                {
                    MessageBox.Show("Valor acima do disponível em banco.");
                    lbl_ctotal.Text = "";
                    txt_cvalor.Text = "";
                }
            }
        }

        private void num_bqtd_ValueChanged(object sender, EventArgs e)
        {
            if (Modulo.metodo_baixa == "Média Ponderada")
            {
                txt_bvalor.Text = (Modulo.baixa_media(cmb_bcredito.Text, Convert.ToInt32(num_bqtd.Value), id_lancamento)).ToString();
            }
            else
            {
                txt_bvalor.Text = (Modulo.baixa_estoque(cmb_bcredito.Text, Convert.ToInt32(num_bqtd.Value), Modulo.metodo_baixa, id_lancamento)).ToString();
            }
        }

        private void num_bqtd_TextChanged(object sender, EventArgs e)
        {

            if (num_bqtd.Value > 0 && num_bqtd.Text != "")
            {
                if (Modulo.metodo_baixa == "Média Ponderada")
                {
                    txt_bvalor.Text = (Modulo.baixa_media(cmb_bcredito.Text, Convert.ToInt32(num_bqtd.Value), id_lancamento)).ToString();
                }
                else
                {
                    txt_bvalor.Text = (Modulo.baixa_estoque(cmb_bcredito.Text, Convert.ToInt32(num_bqtd.Value), Modulo.metodo_baixa, id_lancamento)).ToString();
                }
            }
            else
            {
                txt_bvalor.Text = "";
            }
        }

        private void btn_baixa_Click(object sender, EventArgs e)
        {
            if (cmb_bcredito.Text != "" && cmb_bdebito.Text != "" && txt_bvalor.Text != "" && num_bqtd.Value != 0)
            {


                sql = "insert into tbLancamentos values ('" + id_lancamento + "','" + cmb_bdebito.Text + "','" + cmb_bcredito.Text + "','" + Convert.ToDecimal(txt_bvalor.Text) / num_bqtd.Value + "'," + num_bqtd.Value + ",'" + txt_bvalor.Text + "','" + DateTime.Today + "')";
                Modulo.conexao.Execute(sql, out ret);

                sql = "select * from tbContas where nome='" + cmb_bdebito.Text + "'";
                Modulo.rs = Modulo.conexao.Execute(sql, out ret);

                sql = "update tbContas set valor_entrada='" + (Convert.ToDouble(Modulo.rs.Fields["valor_entrada"].Value) + Convert.ToDouble(txt_bvalor.Text)) + "' where nome='" + cmb_bdebito.Text + "'";
                Modulo.conexao.Execute(sql, out ret);

                sql = "select * from tbContas where nome='" + cmb_bcredito.Text + "'";
                Modulo.rs = Modulo.conexao.Execute(sql, out ret);

                sql = "update tbContas set valor_saida='" + (Convert.ToDouble(Modulo.rs.Fields["valor_saida"].Value) + Convert.ToDouble(txt_bvalor.Text)) + "' where nome='" + cmb_bcredito.Text + "'";
                Modulo.conexao.Execute(sql, out ret);

                MessageBox.Show("Lançamento realizado.");
                id_lancamento++;
                maximo -= Convert.ToInt32(num_bqtd.Value);
                num_bqtd.Maximum = maximo;
                //txt_cvalor.Enabled = false;
                txt_bvalor.Text = "";
                num_bqtd.Value = 0;
                lbl_ctotal.Text = "";
                //num_cqtd.Enabled = false;
                //num_cqtd.Text = "";
                //cmb_cdebito.Text = "";
                //cmb_ccredito.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo.op = new frm_menu();
            Modulo.Abrir_opcao(this, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
