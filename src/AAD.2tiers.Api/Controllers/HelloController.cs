﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AAD._2tiers.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from API";
        }

        [HttpGet]
        [Authorize(Policy = "Read")]
        public string GetWithReadScope()
        {
            return "Hello from API (Read Scope)";
        }

        [HttpGet]
        [Authorize(Policy = "Write")]
        public string GetWithWriteScope()
        {
            return "Hello from API (Write Scope)";
        }

    }
}
