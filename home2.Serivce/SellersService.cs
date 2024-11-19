using home2.Core.Repositories;
using home2.Core.Service;
using home2.Data.Repositories;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Serivce
{
        public class SellersService : ISellersService
    {
        private ISellersRepository _sellersRepositories;
            
        public SellersService(ISellersRepository SellersRepositories)
        {
            _sellersRepositories = SellersRepositories;
        }

        public List<Seller> GetList()
        {
            return _sellersRepositories.GetAll();
        }
    }

}
