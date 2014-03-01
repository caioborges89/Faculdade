using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace V_CICLO.Classes
{
    /// <summary>
    /// Classe responsavel por toda a parte de conexão do Banco de Dados
    /// </summary>
    class ConexaoBanco
    {

#region Objetos de Conexão e Acesso

        static FbConnection _fbConn;
        static FbCommandBuilder _fbComm = new FbCommandBuilder();
        private FbCommand cmd = new FbCommand();
        private string _strConn = "";

#endregion

#region GET & SET

        public static FbConnection FbConn
        {
            get { return _fbConn; }
        }

        public static FbCommandBuilder FbComm
        {
            get { return _fbComm; }
        }

        public string StrConn
        {
            set
            {
                _strConn = "User=SYSDBA;Password=masterkey;"
                           + @"C:\Users\Caio\Documents\GitHub\Faculdade\Projeto LES\Banco\DADOS_V_CICLO_14_I_N.FDB;"
                           + "DataSource=localhost;Port=3050;"
                           + "Dialect=3;Charset=WIN1252;Role=;"
                           + "Connection lifetime=0;"
                           + "Connection timeout=15;"
                           + "Pooling=True;Packet"
                           + " Size=16384;Server Type=0";
            }

            get { return _strConn; }
        }

        /// <summary>
        /// Método responsável por receber a string
        /// de conexão do banco de dados e abrir a 
        /// conexão com o mesmo.
        /// </summary>
        /// <param name="bActive"></param>
        /// Recebe true para abrir a conexão com 
        /// o banco e false para fechar a mesma.
        /// <returns></returns>
        public static Boolean Active(Boolean bActive)
        {
            if (bActive)
            {
                string _conn;
                _conn = "User=SYSDBA;Password=masterkey;"
                                 + @"Database=C:\BancoFirebirdNovo\DADOS_V_CICLO_14_I_N.FDB;"
                                 + "DataSource=localhost;Port=3050;"
                                 + "Dialect=3;Charset=WIN1252;Role=;"
                                 + "Connection lifetime=0;"
                                 + "Connection timeout=15;"
                                 + "Pooling=True;Packet"
                                 + " Size=16384;Server Type=0";
                _fbConn = new FbConnection(_conn);
                try
                {
                    _fbConn .Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                _fbConn .Close();
                return false;
            }
        }

#endregion

        public void executaSql(string comando)
        {
            try
            {
                Active(true);
                cmd.Connection = _fbConn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                Active(false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Active(false);
            }
        }

        public string retornaValorSql(string comando)
        {
            string retorno = "";
            try
            {
                Active(true);
                cmd.Connection = _fbConn;
                cmd.CommandText = comando;
                retorno = cmd.ExecuteScalar().ToString();
                Active(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Active(false);
            }
            return retorno;
        }

        public DataTable retornaDt(string comando)
        {
            DataTable dt = new DataTable();
            Active(true);
            try
            {
                FbDataAdapter fbDa = new FbDataAdapter(comando, _fbConn);
                fbDa.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Active(false);
            }
            return dt;
        }

    }
}
