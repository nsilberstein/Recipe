using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public class BizRecipeSteps : BizObject<BizRecipeSteps>
    {
       string stepdescval = "";
        public BizRecipeSteps()
        {
        }
        public int IngredientId
        {
            get => this.PrimaryKeyValue;
            set => PrimaryKeyValue = value;
        }
        
        public string StepDesc
        {
            get
            {
                return stepdescval;
            }
            set
            {
                stepdescval = value;
                InvokePropertyChanged();
            }
        }
    }
}
