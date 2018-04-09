using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MySampleCadastroProject.Infra.CadastroDataCtx
{
    public class CadastroDataContext : IDisposable
    {
        public CadastroDataContext()
        {
                ConnectionState = new OracleConne ction
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
