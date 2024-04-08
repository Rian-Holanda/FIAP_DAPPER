using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_ESTUDOS_INFRASTRUCTURE.Dapper
{
    public class DB_Config
    {
        private string _config = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FIAP_ESTUDOS_DAPPER;Integrated Security=True";
        
        public string Config {  get { return _config; }  set { value = _config; } } 

        public DB_Config() 
        {
            Config = _config;
        }
    }
}
