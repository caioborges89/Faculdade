using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace V_CICLO.Classes
{
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
                _fbConn.ConnectionString = StrConn;
                _fbConn.Open();
                cmd.Connection = _fbConn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                _fbConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _fbConn.Close();
            }
        }

        public string retornaValorSql(string comando)
        {
            string retorno = "";
            try
            {
                _fbConn.ConnectionString = _strConn;
                _fbConn.Open();
                cmd.Connection = _fbConn;
                cmd.CommandText = comando;
                retorno = cmd.ExecuteScalar().ToString();
                _fbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _fbConn.Close();
            }
            return retorno;
        }

        public DataTable retornaDt(string comando)
        {
            DataTable dt = new DataTable();
            Active(true);
            try
            {
                //_fbConn = new FbConnection(_strConn);
                //_fbConn.Open();
                FbDataAdapter fbDa = new FbDataAdapter(comando,_fbConn );
                fbDa.Fill(dt);
                //_fbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Active(false);
            return dt;
        }

    }
}
