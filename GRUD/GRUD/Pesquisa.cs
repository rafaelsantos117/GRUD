using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace GRUD
{
    public class Pesquisa
    {
        string conexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                "            D:\\Projetos\\GRUD\\GRUD\\GRUD\\Agencia.mdb";
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;

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
                    lista.DgdPesquisa.Rows.Add(dr.GetValue(0).ToString(), dr.GetValue(1).ToString());
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
    }
}
