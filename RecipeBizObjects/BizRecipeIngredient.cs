using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public class BizRecipeIngredient : BizObject<BizRecipeIngredient>
    {
        string ingredientnameval = "";
        string ingredientsval = "";
        public BizRecipeIngredient()
        {

        }

        public int IngredientId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }

        public string IngredientName
        {
            get
            {
                return ingredientnameval;
            }
            set
            {
                ingredientnameval = value;
                InvokePropertyChanged();
            }
        }

        public string Ingredients
        {
            get
            {
                return ingredientsval;
            }
            set
            {
                ingredientsval = value;
                InvokePropertyChanged();
            }
        }
    }
}

    
    

