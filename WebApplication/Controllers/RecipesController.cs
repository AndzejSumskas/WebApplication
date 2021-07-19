using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]

        public ActionResult GetRecipes([FromQuery]int count)
        {
            Recipe[] recipes =
            {
                new() { Title = "Oxtail"},
                new() { Title = "Curry Chiken"},
                new() { Title = "Dumplings"}
            };

            return Ok(recipes.Take(count));
        }

        [HttpPost]

        public ActionResult CreateNewRecipes([FromBody] Recipe newRecipe)
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return Created("", newRecipe);
        }

        [HttpDelete("all")]   //"{id}"   api/recipes/all  OR  api/recipes/1

        public ActionResult DeleteRecipes()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();
        }
    }
}
