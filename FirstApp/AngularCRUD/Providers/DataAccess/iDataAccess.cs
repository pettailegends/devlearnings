using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCRUD.Providers.DataAccess
{
    public interface iDataAccess
    {
        string GetData(Model.ConnectionInfo coninfo);
    }
}
