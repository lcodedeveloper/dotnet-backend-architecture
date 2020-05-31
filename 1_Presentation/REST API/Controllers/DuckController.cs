using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuckController : ControllerBase
    {
        private IDuckFacade api;
        public DuckController(IDuckFacade api)
        {
            this.api = api;
        }

        // criar os endpoints do CRUD
    }
}