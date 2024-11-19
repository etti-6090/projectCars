using home2.Core.Repositories;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Data.Repositories
{
    public class TurnsRepository : ITurnsRepository
    {
        private readonly DataContext _context;

        public TurnsRepository(DataContext context)
        {
            _context = context;
        }
        public List<Turn> GetAll()
        {
            return _context.Turn;
        }
       
    }
}
