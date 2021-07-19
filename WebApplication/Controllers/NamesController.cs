using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        [HttpGet]

        public string[] GetNames()
        {
            string[] names = { "Tomas", "Karolina", "Simas" };

            return names;
        }

        [HttpDelete("{id}")]   //"(all)"  api/recipes/all  OR  api/recipes/1

        public ActionResult DeleteName(string id)
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();
        }

    }
}
