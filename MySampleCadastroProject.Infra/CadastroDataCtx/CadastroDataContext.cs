using System;
using System.Data;
using System.Data.SqlClient;
using MySampleCadastroProject.Shared;
using Oracle.ManagedDataAccess.Client;

namespace MySampleCadastroProject.Infra.CadastroDataCtx
{
    public class CadastroDataContext : IDisposable
    {
        public static OracleConnection _conn;

        public CadastroDataContext()
        {
            Connection();
        }


        public void Dispose()
        {
            if (_conn.State != ConnectionState.Closed)
            {
                _conn.Close();
                _conn.Dispose();
                _conn = null;

            }
        }

        public void Connection()
        {
            _conn = new OracleConnection();
            _conn.ConnectionString = Settings.ConnectionString;
            _conn.Open();
        }
    }
}
