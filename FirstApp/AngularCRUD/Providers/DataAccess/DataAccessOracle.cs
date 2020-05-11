using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCRUD.Providers.DataAccess
{
    public class DataAccessOracle : iDataAccess
    {
        public string GetData(Model.ConnectionInfo coninfo)
        {
            return "Oracle fetched";
        }
    }
}
