using Dapper;
using FIAP_ESTUDOS_DOMAIN.Entities;
using FIAP_ESTUDOS_INFRASTRUCTURE.Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FIAP_ESTUDOS_DADOS.Command
{
    public class CustomerCommand
    {
        private DB_Command command = new DB_Command();
        private DB_Config db_config =  new DB_Config();


        public int? InsertCustomerAsync(Customer customer)
        {
            try
            {
               var result = command.InsertAsync("INSERT INTO [tbCustomer] VALUES(@Name, @Email, @Adress);SELECT CAST(scope_identity() AS INT)"
                                                 , new{Name = customer.Name,Email = customer.Email,Adress = customer.Adress}
                                                 ,db_config.Config);      
                
                return result;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
