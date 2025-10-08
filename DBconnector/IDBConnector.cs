using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnector
{
    internal interface IDBConnector
    {
        Task<bool> Ping();
    }
}
