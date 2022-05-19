using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodItemWebAPI.services;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {

        private readonly IFoodItemService _foodItemService;
        public FoodItemController(IFoodItemService foodItemService)
        {
            _foodItemService = foodItemService;
        }
        [HttpGet]
        [Route("GetFoodItems/")]
        public async Task<ActionResult<IEnumerable<FoodItems>>> GetFoodItems()
        {
            return (await _foodItemService.GetFoodItems()).ToList();
        }



    }
}
