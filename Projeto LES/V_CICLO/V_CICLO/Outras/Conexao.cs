﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace V_CICLO.Outras
{
    class Conexao
    {
        static FbConnection fbCnn;
        static FbCommandBuilder fbCmm = new FbCommandBuilder();

        public static FbConnection FbCnn{
            get { return fbCnn; }
        }

        public static FbCommandBuilder FbCmm{
            get { return fbCmm; }
        }

        public static Boolean Active (Boolean bActive){
            if (bActive){
                string _conn;
                _conn = "User=SYSDBA;Password=masterkey;"
                                 + @"Database=C:\Bancos_Firebird\DADOS_V_CICLO_14_I_N.fdbb;"
                                 + "DataSource=localhost;Port=3050;"
                                 + "Dialect=3;Charset=WIN1252;Role=;"
                                 + "Connection lifetime=0;"
                                 + "Connection timeout=15;"
                                 + "Pooling=True;Packet"
                                 + " Size=16384;Server Type=0";
                fbCnn = new FbConnection(_conn);
                try{
                fbCnn.Open();
                return true;
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else {
                fbCnn.Close();
                return false;
            }
        }

        public DataTable retornaDt(string comando)
        {
            DataTable dt = new DataTable();
            Active(true);
            try
            {
                //_fbConn = new FbConnection(_strConn);
                //_fbConn.Open();
                FbDataAdapter fbDa = new FbDataAdapter(comando, fbCnn);
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
