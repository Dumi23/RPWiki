using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class RPDataController: ControllerBase
    {
        [HttpGet]

        public string GetCharacter()
        {
            return "da";
        }

        [HttpGet("{id}")]
        public string GetStateByID()
        {
            return "e";
        }


    }
}