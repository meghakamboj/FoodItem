using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FoodItemWebAPI.services
{
    public class FoodItemService:IFoodItemService
    {

        public static readonly List<FoodItems> foodItems = new List<FoodItems>()
            {
               new FoodItems {FoodItemId =01,FoodItemName="Shahi Paneer",Price=250},
               new FoodItems {FoodItemId =02,FoodItemName="Biryani",Price=200},
               new FoodItems {FoodItemId =03,FoodItemName="Veg Thali",Price=180},
               new FoodItems {FoodItemId =04,FoodItemName="Chiken Thali",Price=280},
               new FoodItems {FoodItemId =05,FoodItemName="Mutton Thali",Price=350}

            };




        public async Task<IEnumerable<FoodItems>> GetFoodItems()
        {
            await Task.Delay(1000);
            return foodItems;
        }

    }
}
