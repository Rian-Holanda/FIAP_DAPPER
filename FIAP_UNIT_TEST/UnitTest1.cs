using FIAP_ESTUDOS_DADOS.Command;
using FIAP_ESTUDOS_DOMAIN.Entities;
using Xunit;

namespace FIAP_UNIT_TEST
{
    public class UnitTest1
    {
        CustomerCommand customerCommand = new CustomerCommand();
        

        [Fact]
        public void Test1()
        {
            Customer customer = new Customer { Name = "Teste", Email = "teste@teste.com", Adress = "Rua Teste" };

            customerCommand.InsertCustomerAsync(customer);
        }
    }
}