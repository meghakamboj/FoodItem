using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantAPI.Models;

namespace FoodItemWebAPI.services
{
    public interface IFoodItemService
    {
        Task<IEnumerable<FoodItems>> GetFoodItems();

    }
}
