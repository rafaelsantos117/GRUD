using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GRUD
{
    public partial class FrmPesquisaGeral : Form
    {
        string conexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                "            D:\\Projetos\\GRUD\\GRUD\\GRUD\\Agencia.mdb";
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public FrmPesquisaGeral()
        {
            InitializeComponent();
        }

        public void Pessoas(string p, string o)
        {
            try
            {
                string parametro, ordem;
                parametro = p;
                ordem = o;
                FrmPesquisaGeral lista = new FrmPesquisaGeral();
                cn = new OleDbConnection(conexao);
                cmd = new OleDbCommand("Select CodCli, NomeCli from Clientes Where NomeCli Like '*@Parametro*' " +
                      "Order by @Ordem", cn);
                cmd.Parameters.Add("@Parametro", OleDbType.VarChar).Value = parametro;
                cmd.Parameters.Add("@Ordem", OleDbType.VarChar).Value = ordem;

                cn.Open();
                dr = cmd.ExecuteReader();
                do
                {
                    DgdPesquisa.Rows.Add(dr.GetValue(0).ToString(), dr.GetValue(1).ToString());
                } while (dr.Read());

                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensagem de erro: " + ex.ToString() + " - " + ex.Message, "Atenção", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!(TxtDescricao.Text.Equals(String.Empty)))
            {
                DgdPesquisa.Rows.Clear();
                if (RdbAlfabetica.Checked)
                {
                    Pessoas(TxtDescricao.Text, "NomeCli");
                }
                else
                {
                    Pessoas(TxtDescricao.Text, "CodCli");
                }
            }
        }
    }
}
