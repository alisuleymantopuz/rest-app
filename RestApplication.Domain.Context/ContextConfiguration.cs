﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApplication.Domain.Context
{
    public class ContextConfiguration
    {
        public string ConnectionString { get { throw new NotImplementedException(); } }

        public bool DatabaseStatusCheck { get { throw new NotImplementedException(); } }

        public string ProviderName { get { throw new NotImplementedException(); } }
    }
}
