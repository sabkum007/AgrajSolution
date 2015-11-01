using DataEntities;
using DLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLayer
{
    public class BUserInteractions
    {
        DUserInteractions _dUserInteractions = null;
        public BUserInteractions(string connStr)
        {
            _dUserInteractions = new DUserInteractions(connStr);
        }
        public void Insert(UserLogs objUserLogs)
        {
            _dUserInteractions.Insert(objUserLogs);
        }
    }
}
