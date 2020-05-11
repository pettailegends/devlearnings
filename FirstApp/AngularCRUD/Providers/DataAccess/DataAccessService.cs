using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCRUD.Providers.DataAccess
{
    public class DataAccessService
    {
        private iDataAccess _DataAccess;
        public DataAccessService(iDataAccess DataAccess)
        {
            _DataAccess = DataAccess;
        }

        public string GetTablesNames(Model.ConnectionInfo coninfo)
        {
            return _DataAccess.GetData(coninfo);
        }
    }
}
