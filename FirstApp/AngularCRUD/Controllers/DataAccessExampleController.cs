using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularCRUD.Providers;
using AngularCRUD.Providers.DataAccess;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AngularCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DataAccessExampleController : ControllerBase
    {
        [HttpGet]
        [ResponseCache(Duration = 60,Location = ResponseCacheLocation.Any)]
        [AllowAnonymous]
        public IActionResult Get()
        {
            string userid = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
            Model.ConnectionInfo conInfo = new Model.ConnectionInfo();
            conInfo.UserName = userid;
            DataAccessSQL s = new DataAccessSQL();
            //DataAccessOracle s = new DataAccessOracle();
            DataAccessService dservice = new DataAccessService(s);
            string ret = dservice.GetTablesNames(conInfo);
            return Ok(ret);
        }
    }
}