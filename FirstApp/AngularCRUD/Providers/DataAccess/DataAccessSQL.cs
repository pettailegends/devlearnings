using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCRUD.Providers.DataAccess
{
    public class DataAccessSQL : iDataAccess
    {
        public string GetData(Model.ConnectionInfo coninfo)
        {
            return "SQL Data fetched";
        }
    }
}
