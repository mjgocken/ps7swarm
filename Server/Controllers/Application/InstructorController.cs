using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWARM.EF.Data;
using SWARM.EF.Models;
using SWARM.Server.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWARM.Server.Controllers.Application
{
    public class InstructorController : BaseController, iBaseController<Instructor>
    {
        public InstructorController(SWARMOracleContext context, IHttpContextAccessor httpContextAccessor)
            : base(context, httpContextAccessor)
        {

        }

        public Task<IActionResult> Delete(int KeyValue)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Get(int KeyValue)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Post([FromBody] Instructor _Item)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Put([FromBody] Instructor _Item)
        {
            throw new NotImplementedException();
        }
    }
}
