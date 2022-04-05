using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IIngredientsStorage
    {
        Task<IEnumerable<Ingredients>> GetIngredients();
    }
}
