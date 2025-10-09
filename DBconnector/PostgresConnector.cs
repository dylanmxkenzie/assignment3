using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnector
{
    public class PostgresConnector : IDBConnector
    {
        public async Task<bool> Ping()
        {
            try
            {
                await Task.Delay(10);
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
