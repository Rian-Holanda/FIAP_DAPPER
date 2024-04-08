using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_ESTUDOS_INFRASTRUCTURE.Dapper
{
    public class DB_Command
    {
        public int? InsertAsync(string query, object parametros, string stringConnection) 
        {
             using (var connection = new SqlConnection(stringConnection))
            {
                try 
                {

                    var id = (int?)connection.ExecuteScalar(query, parametros);

                    return id;
                }
                catch (Exception ex) 
                {
                    return 0;
                }

            }
        }
    }
}
