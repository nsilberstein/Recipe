using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Dapper;

namespace RecipeBizObjects
{
    public class BizRecipe : BizObject<BizRecipe>
    {
        int createdbyuseridval = 0;
        int cuisinetypeidval = 0;
        string recipenameval = "";
        int numcaloriesperserving;
        int numofingredients;
        int numofsteps;
        DateTime datecreatedval = DateTime.Now;
        DateTime? datepublishedval;
        DateTime? datearchivedval;
        string recipestatusval = "";
        string codeval = "";
        string messageval = "";
        int imagecodeval = 0;
        public BizRecipe() 
        {
            this.DynamParamForUpdate.Output(this, x => x.DateCreated);
            this.DynamParamForUpdate.Output(this, x => x.DatePublished, size: 20);
            this.DynamParamForUpdate.Output(this, x => x.DateArchived, size: 20);
            this.DynamParamForUpdate.Output(this, x => x.RecipeStatus);
            this.DynamParamForUpdate.Output(this, x => x.NumofIngredients);
            this.DynamParamForUpdate.Output(this, x => x.NumofSteps);
            this.DynamParamForUpdate.Output(this, x => x.Code);
            this.DynamParamForUpdate.Output(this, x => x.ImageCode);         
        }

        public static List<BizRecipe> Search(string criteria)
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("SearchCriteria", criteria);
            return GetAllFromSproc("RecipeSearch", dp);
        }

    

        public int RecipeId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }

        [Display(Name = "Created By")]
        public int CreatedByUserId
        {
            get
            {
                return createdbyuseridval;
            }
            set
            {
                createdbyuseridval = value;
                InvokePropertyChanged();
            }
        }

        [Display(Name = "Cuisine Type")]
        public int CuisineTypeId
        {
            get
            {
                return cuisinetypeidval;
            }
            set
            {
                cuisinetypeidval = value;
                InvokePropertyChanged();
            }
        }

        [Display(Name = "Recipe Name")]
        public string RecipeName
        {

            get
            {
                return recipenameval;
            }
            set
            {
                recipenameval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Number of Calories Per Serving")]
        public int NumCaloriesPerServing
        {
            get
            {
                return numcaloriesperserving;
            }
            set
            {
                numcaloriesperserving = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Number of Ingredients")]
        public int NumofIngredients
        {
            get
            {
                return numofingredients;
            }
            set
            {
                numofingredients = value;
                InvokePropertyChanged();
            }
        }


        [Display(Name = "Number of Steps")]
        public int NumofSteps
        {
            get
            {
                return numofsteps;
            }
            set
            {
                numofsteps = value;
                InvokePropertyChanged();
            }
        }


        [Display(Name = "Date Created")]
        public DateTime DateCreated
        {
            get
            {
                return datecreatedval;
            }
            set
            {
                datecreatedval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Date Published")]
        public DateTime? DatePublished
        {
            get
            {
                return datepublishedval;
            }
            set
            {
                datepublishedval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Date Archived")]
        public DateTime? DateArchived
        {
            get
            {
                return datearchivedval;
            }
            set
            {
                datearchivedval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Recipe Status")]
        public string RecipeStatus
        {
            get
            {
                return recipestatusval;
            }
            set
            {
                recipestatusval = value;
                InvokePropertyChanged();
            }
        }

        public string Code
        {
            get
            {
                return codeval;
            }
            set
            {
                codeval = value;
                InvokePropertyChanged();
            }
        }
        public int ImageCode
        {
            get
            {
                return imagecodeval;
            }
            set
            {
                imagecodeval = value;
                InvokePropertyChanged();
            }
    
        }

        public string Message
        {
            get
            {
                return messageval;
            }
            set
            {
                messageval = value;
                InvokePropertyChanged();
            }
        }
        public string FullDescription() { return  this.RecipeName; }


        public List<BizRecipeIngredient> GetListOfIngredientPerRecipe()
        {
            List<BizRecipeIngredient> lst;
            lst = BizRecipeIngredient.GetList("RecipeId", this.RecipeId);
            return lst;
        }

        public List<BizRecipeSteps> GetListOfStepPerRecipe()
        {
            List<BizRecipeSteps> lst;
            lst = BizRecipeSteps.GetList("RecipeId", this.RecipeId);
            return lst;
        }

        public  List<BizUserName> UserNameList()
        {
            return BizUserName.GetAll();
        }

        public List<BizCuisineType> CuisineTypeList()
        {
            return BizCuisineType.GetAll();
        }
    }
}
