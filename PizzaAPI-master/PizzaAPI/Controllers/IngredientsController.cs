using Contract;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientsRepository ingredients;

        public IngredientsController(IIngredientsRepository ingredients)
        {
            this.ingredients = ingredients;
        }
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var oresult = await ingredients.GetIngredients();
            return Ok(oresult);
        }
    }
}
