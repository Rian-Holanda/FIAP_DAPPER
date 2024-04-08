using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_ESTUDOS_DOMAIN.Entities
{
    public class Customer
    {
        private int _customer_Id;
        private string _name;
        private string _email;
        private string _adress;

        public int Customer_Id {  get { return _customer_Id; } set { _customer_Id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Adress { get { return _adress; } set { _adress = value; } }


    }
}
