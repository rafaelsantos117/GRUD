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
    public partial class FrmClientes : Form
    {
        string conexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                "            D:\\Projetos\\GRUD\\GRUD\\GRUD\\Agencia.mdb";
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;
        int ultimoregistro = 0;
        int primeiroregistro = 0;
        bool novo = false;

        public FrmClientes()
        {
            InitializeComponent();
        }

        public int RetornaPrimeiroUltimoRegistro(bool PU)
        {
            int registro = 0;
            try
            {
                cn = new OleDbConnection(conexao);
                cn.Open();
                if (PU == true)
                {
                    cmd = new OleDbCommand("Select MAX(CodCli) from Clientes", cn);
                }
                else
                {
                    cmd = new OleDbCommand("Select MIN(CodCli) from Clientes", cn);
                }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    registro = dr.GetInt32(0);

                }
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

            return registro;
        }

        private void RetornaDados(int cod)
        {

            try
            {
                cn = new OleDbConnection(conexao);
                cn.Open();
                if (cod == 0)
                {
                    cmd = new OleDbCommand("Select * from Clientes where CodCli = (Select MIN(CodCli) from Clientes)", cn);
                }
                else
                {
                    cmd = new OleDbCommand("Select * from Clientes where CodCli = " + cod, cn);
                }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TxtCodigo.Text = dr.GetInt32(0).ToString();
                    TxtNome.Text = dr.GetString(1);
                    TxtEndereco.Text = dr.GetString(2);
                    MskTelefone.Text = dr.GetString(3);
                    DtpDataCadastro.Text = dr.GetDateTime(4).ToString();
                    dr.Close();
                    TxtNome.Focus();
                }
                else
                {
                    if (cod < ultimoregistro)
                    {
                        RetornaDados(cod + 1);
                    }
                    else
                    {
                        if (MessageBox.Show("Não há registros cadastrados, Deseja efetuar um cadastro?", "Atenção",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            TxtCodigo.Text = "1";
                            TxtNome.Focus();
                        }
                        else
                        {
                            BtnPrimeiro.Enabled = false;
                            BtnAnterior.Enabled = false;
                            BtnProximo.Enabled = false;
                            BtnUltimo.Enabled = false;
                            BtnApagar.Enabled = false;
                        }
                    }
                }
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

        private void Cadastrar()
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(conexao);
                cn.Open();
                cmd = new OleDbCommand("Insert Into Clientes(CodCli, NomeCli, EndCli, TelCli, DataCadastro) " +
                                       "Values(@Codigo, @Nome, @Endereco, @Telefone, @DataCadastro)", cn);
                cmd.Parameters.Add("@Codigo", OleDbType.Integer).Value = int.Parse(TxtCodigo.Text);
                cmd.Parameters.Add("@Nome", OleDbType.VarChar).Value = TxtNome.Text;
                cmd.Parameters.Add("@Endereco", OleDbType.VarChar).Value = TxtEndereco.Text;
                cmd.Parameters.Add("@Telefone", OleDbType.VarChar).Value = MskTelefone.Text;
                cmd.Parameters.Add("@DataCadastro", OleDbType.DBDate).Value = DateTime.Parse(DtpDataCadastro.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ultimoregistro++;
        }

        private void Atualizar()
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(conexao);
                cn.Open();
                cmd = new OleDbCommand("Update Clientes Set NomeCli = @Nome, EndCli = @Endereco, " +
                                       "TelCli = @Telefone, DataCadastro = @DataCadastro Where CodCli = @Codigo ", cn);
                cmd.Parameters.Add("@Nome", OleDbType.VarChar).Value = TxtNome.Text;
                cmd.Parameters.Add("@Endereco", OleDbType.VarChar).Value = TxtEndereco.Text;
                cmd.Parameters.Add("@Telefone", OleDbType.VarChar).Value = MskTelefone.Text;
                cmd.Parameters.Add("@DataCadastro", OleDbType.DBDate).Value = DateTime.Parse(DtpDataCadastro.Text);
                cmd.Parameters.Add("@Codigo", OleDbType.Integer).Value = int.Parse(TxtCodigo.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro atualizado com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void Apagar()
        {
            int aux = int.Parse(TxtCodigo.Text);
            try
            {
                OleDbConnection cn = new OleDbConnection(conexao);
                cn.Open();
                cmd = new OleDbCommand("Delete * from Clientes where CodCli = " + int.Parse(TxtCodigo.Text), cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O registro nº " + aux + " foi excluído com sucesso.", "OK", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
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

            RetornaDados(aux++);
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            RetornaDados(0);
            primeiroregistro = RetornaPrimeiroUltimoRegistro(false);
            ultimoregistro = RetornaPrimeiroUltimoRegistro(true);
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {

            if (novo == true)
            {
                Cadastrar();
                ultimoregistro++;
                TxtCodigo.Text = ultimoregistro.ToString();
                TxtNome.Text = "";
                TxtEndereco.Text = "";
                MskTelefone.Text = "";
                DtpDataCadastro.Text = "";
                TxtNome.Focus();
            }
            else
            {
                Atualizar();
            }

        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(TxtCodigo.Text);
            if (int.Parse(TxtCodigo.Text) > primeiroregistro)
            {
                RetornaDados(cod - 1);
            }
            else
            {
                MessageBox.Show("Não há mais registros anteriores.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(TxtCodigo.Text);
            if (int.Parse(TxtCodigo.Text) < ultimoregistro)
            {
                RetornaDados(cod + 1);
            }
            else if (int.Parse(TxtCodigo.Text) == ultimoregistro)
            {
                MessageBox.Show("Não há mais registros seguintes.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnPrimeiro_Click(object sender, EventArgs e)
        {
            RetornaDados(primeiroregistro);
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            RetornaDados(ultimoregistro);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            BtnPrimeiro.Enabled = false;
            BtnAnterior.Enabled = false;
            BtnProximo.Enabled = false;
            BtnUltimo.Enabled = false;
            BtnGravar.Enabled = true;
            BtnAnterior.Enabled = true;
            TxtCodigo.Text = (ultimoregistro + 1).ToString();
            TxtNome.Text = "";
            TxtEndereco.Text = "";
            MskTelefone.Text = "";
            DtpDataCadastro.Text = "";
            TxtNome.Focus();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja excluir o registro nº " + TxtCodigo.Text + "? ", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Apagar();
            }
            else
            {
                BtnProximo.Focus();
            }
        }
    }
}

