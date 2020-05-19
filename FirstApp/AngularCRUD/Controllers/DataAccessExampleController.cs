﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularCRUD.Providers;
using AngularCRUD.Providers.DataAccess;

namespace AngularCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataAccessExampleController : ControllerBase
    {
        public IActionResult Get()
        {
            DataAccessSQL s = new DataAccessSQL();
            DataAccessService dservice = new DataAccessService(s);
            string ret = dservice.GetTablesNames(new Model.ConnectionInfo());
            return Ok(ret);
        }
    }
}