using home2.Core.Repositories;
using home2.Core.Service;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Serivce
{
    public class TurnsService : ITurnsService
    {
        private ITurnsRepository _turnsRepositories;

        public TurnsService(ITurnsRepository SellersRepositories)
        {
            _turnsRepositories = SellersRepositories;
        }

        public List<Turn> GetList()
        {
            return _turnsRepositories.GetAll();
        }
    }
}
