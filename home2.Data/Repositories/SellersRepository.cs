using home2.Core.Repositories;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static home2.Core.Repositories.ISellersRepository;

namespace home2.Data.Repositories
{
    public class SellersRepository: ISellersRepository
    {
        private readonly DataContext _context;
        public SellersRepository(DataContext context)
        {
            _context = context;
        }
        public List<Seller> GetAll()
        {
            return _context.Seller;
        }
    }
}
