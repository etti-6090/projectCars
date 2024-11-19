using home2.Core.Service;
using home2.Data.Repositories;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Service
{
    public class CustomersService: ICustomersService
    {
        private  CustomersRepository _CustomersRepositories;
        public CustomersService(CustomersRepository customersRepositories)
        {
            _CustomersRepositories = customersRepositories;
        }

        public List<Customer> GetList()
        {
            return _CustomersRepositories.GetAll();

        }
    }
}
