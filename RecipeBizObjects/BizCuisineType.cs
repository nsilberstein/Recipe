using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public class BizCuisineType : BizObject<BizCuisineType>
    {
        string cuisinenameval = "";
        public BizCuisineType()
        {

        }

        public int CuisineTypeId
        {
            get => this.PrimaryKeyValue;
            set => PrimaryKeyValue = value;
        }

        public string CuisineName
        {
            get
            {
                return cuisinenameval;
            }
            set
            {
                cuisinenameval = value;
                InvokePropertyChanged();
            }
        }
    }
}
