using System;
using System.Data;
using System.Data.SqlClient;
using MySampleCadastroProject.Shared;

namespace MySampleCadastroProject.Infra.CadastroDataCtx
{
    public class CadastroDataContext : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public CadastroDataContext()
        {
                Connection = new SqlConnection(Settings.ConnectionString);
            Connection.OpenAsync();
        }
        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
