using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarejoConnect.Model.Repositorios
{
    public class ConnectionDb : IDisposable
    {

        public NpgsqlConnection Connection { get; set; }

        public ConnectionDb()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=VarejoDB;User Id = postgres;Password=postgres;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
