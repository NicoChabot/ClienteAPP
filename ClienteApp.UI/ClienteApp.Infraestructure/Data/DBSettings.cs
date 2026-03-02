using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteApp.Infrastrucure.Data;

public static class DBSettings
{
    public static string ConnectionString =>
        "Server=localhost;Database=ClienteDB;Trusted_Connection=True;TrustServerCertificate=True;";
}
