using Contract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private readonly IIngredientsStorage ingredientsStorage;

        public IngredientsRepository(IIngredientsStorage ingredientsStorage)
        {
            this.ingredientsStorage = ingredientsStorage;
        }
      

        

        public async Task<IEnumerable<Ingredients>> GetIngredients()
        {
            return await ingredientsStorage.GetIngredients();
        }
    }
}
