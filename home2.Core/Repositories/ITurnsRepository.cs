﻿using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Core.Repositories
{
    public interface ITurnsRepository
    {
        public List<Turn> GetAll();
    }   
}
