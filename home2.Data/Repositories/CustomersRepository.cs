using home2.Core.Repositories;
using home2.Core.Service;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Data.Repositories
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly DataContext _context;
        public CustomersRepository(DataContext context)
        {
            _context = context;
        }
        public List<Customer> GetAll()
        {
            return _context.Customer;
        }
        public List <Customer>  Get(string id)
        {
            return _context.Customer;

        }
        public List<Customer> Post( Customer value)
        {
            return _context.Customer;
        }
    }
}
