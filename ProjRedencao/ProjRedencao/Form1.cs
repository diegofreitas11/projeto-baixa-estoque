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

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Modulo.conexao_banco();

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            object ret;
            Modulo.trava = true;
            string sql = "select * from tbEmpresa";
            Modulo.rs = Modulo.conexao.Execute(sql,out ret,0);

            if (Modulo.rs.EOF == true)
            {
               
                Modulo.op = new frm_empresa();
                Modulo.Abrir_opcao(this, true);

            }
            else
            {
                sql = "select * from tbUsuarios";
                Modulo.rs = Modulo.conexao.Execute(sql, out ret, 0);
                if (Modulo.rs.EOF == true)
                {
                    
                    Modulo.op = new frm_admin();
                    Modulo.Abrir_opcao(this, true);

                }
                else
                {
                    
                    Modulo.op = new frm_login();
                    Modulo.Abrir_opcao(this, true);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public static class Modulo
    {
        public static ADODB.Connection conexao;
        public static ADODB.Recordset rs, rx;
        public static bool trava;
        public static string nivel, metodo_baixa;
        public static int id_conta = 1;

        public static Form op;
        public static Form primeiro_form;

        public static void Thread()
        {
            Application.Run(op);
        }

        public static void conexao_banco()
        {
            
            conexao = new ADODB.Connection();
            string conexaostr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + Application.StartupPath + "\\dbRedemption.mdb";
            rs = new ADODB.Recordset();
            rx = new ADODB.Recordset();
            conexao.Open(conexaostr, "", "", -1);
            MessageBox.Show("Conexão bem sucedida");
        }

        public static double baixa_estoque(string estoque, int quantidade, string metodo, int indice)
        {
            object ret;
            double valor_total = 0;
            int estoque_baixado = 0;
            string ordem = "", sql;

            if (metodo == "UEPS")
            {
                ordem = "order by id desc";
            }
            else
            {
                sql = "select * from tbLancamentos where (crédito='" + estoque + "') and id < " + indice + " " + ordem + "";
                rs = conexao.Execute(sql, out ret);
                while(rs.EOF == false)
                {
                    estoque_baixado += Convert.ToInt32(rs.Fields["quantidade"].Value);
                    rs.MoveNext();
                }
            }


            sql = "select * from tbLancamentos where (crédito='" + estoque + "' or débito='" + estoque + "') and id < " + indice + " " + ordem + "";
            rs = conexao.Execute(sql, out ret);

            while(rs.EOF == false && quantidade > 0)
            {
                if (rs.Fields["débito"].Value.ToString() == estoque)
                {
                    if (quantidade > (Convert.ToInt32(rs.Fields["quantidade"].Value) - estoque_baixado))
                    {
                        if ((Convert.ToInt32(rs.Fields["quantidade"].Value) - estoque_baixado) >= 0)
                        {
                            quantidade = quantidade - (Convert.ToInt32(rs.Fields["quantidade"].Value) - estoque_baixado);
                            valor_total = valor_total + (Convert.ToInt32(rs.Fields["quantidade"].Value) - estoque_baixado) * Convert.ToDouble(rs.Fields["valor_unitario"].Value);
                            estoque_baixado = 0;
                        }
                        else
                        {
                            estoque_baixado -= Convert.ToInt32(rs.Fields["quantidade"].Value);
                        }
                    }
                    else
                    {
                        valor_total = valor_total + quantidade * Convert.ToDouble(rs.Fields["valor_unitario"].Value);
                        quantidade = 0;
                    }
                }
                else
                {
                    if (metodo == "UEPS")
                    {
                        estoque_baixado += Convert.ToInt32(rs.Fields["quantidade"].Value);
                    }
                }
                rs.MoveNext();
                
            }
            
            return valor_total;

        }

        public static double baixa_media(string estoque, int quantidade, int indice)
        {
            object ret;
            double valor_total = 0, quantidade_total = 0, valor_medio;
            string sql = "select * from tbLancamentos where (débito='" + estoque + "' or crédito='" + estoque + "') and id <" + indice + "";
            rs = conexao.Execute(sql, out ret);

            while (rs.EOF == false)
            {
                if (rs.Fields["débito"].Value.ToString() == estoque)
                {
                    valor_total += Convert.ToDouble(rs.Fields["valor_total"].Value);
                    quantidade_total += Convert.ToDouble(rs.Fields["quantidade"].Value);
                }
                else
                {
                    valor_total -= Convert.ToDouble(rs.Fields["valor_total"].Value);
                    quantidade_total -= Convert.ToDouble(rs.Fields["quantidade"].Value);
                }

                rs.MoveNext();
            }

            valor_medio = (valor_total / quantidade_total) * quantidade;

            return valor_medio;
        }

        public static void Abrir_opcao(Form form, bool inicial)
        {
            
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Thread));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
            if (inicial)
            {
                form.Hide();
                
            }
            else
            {
                form.Close();
            }
        }



    }
}
