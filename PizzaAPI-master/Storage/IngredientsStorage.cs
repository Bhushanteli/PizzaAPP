using Contract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class IngredientsStorage : IIngredientsStorage
    {
        

       public async Task<IEnumerable<Ingredients>> GetIngredients()
        {
             var ingards= new List<Ingredients> {
                    new Ingredients{ Name="I1", Price=100,isApplied=false },
                    new Ingredients{ Name="I2", Price=20,isApplied=false },
                    new Ingredients{ Name="I3", Price=30,isApplied=false },
                    new Ingredients{ Name="I4", Price=20,isApplied=false },
                    new Ingredients{ Name="I5", Price=60,isApplied=false },
                    new Ingredients{ Name="I6", Price=100,isApplied=false },

            };
            return await Task.FromResult(ingards);
        }
    }
}
