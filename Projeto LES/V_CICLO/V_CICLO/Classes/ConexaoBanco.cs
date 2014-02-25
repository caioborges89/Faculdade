﻿using System;
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

        private static FbConnection _fbConn = new FbConnection();
        private static FbCommandBuilder _fbComm = new FbCommandBuilder();
        private FbCommand cmd = new FbCommand();
        private static String _strConn = "";

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

        public static String StrConn
        {
            set
            {
                _strConn = "User=SYSDBA;Password=masterkey" +
                           "DataSource=localhost; Database=C:\\Bancos_Firebird" +
                           "DADOS_V_CICLO_14_I_N.FDB;";
            }

            get { return _strConn; }
        }

#endregion

        public void executaSql(string comando)
        {
            try
            {
                _fbConn.ConnectionString = _strConn;
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

            try
            {
                _fbConn.Open();
                FbDataAdapter fbDa = new FbDataAdapter(comando, _fbConn);
                fbDa.Fill(dt);
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
            return dt;
        }

    }
}