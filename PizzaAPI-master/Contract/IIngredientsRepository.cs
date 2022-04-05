using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
  public  interface IIngredientsRepository
    {
        Task<IEnumerable<Ingredients>> GetIngredients();
    }
}
