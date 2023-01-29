using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public static class DataService
    {
        //private static string connstring = "nsilberstein.database.windows.net,1433, RecipeDB, nsilbersteinadmin, CPU123!@#";
        //public static string ConnectionString { get => connstring; }
        public static DataTable GetNumberList()
        {

            return SQLUtility.GetDataTableFromSproc(DataUtility.ConnectionString, "NumberGet");
        }

        public static DataTable GetRecipeList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "RecipeGet");
            cmd.Parameters["@All"].Value = true;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }

        public static DataTable GetRecipeById(int id) 
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "RecipeGet");
            cmd.Parameters["@RecipeId"].Value = id;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }

        public static DataTable GetIngredientList(int RecipeId)
        {

            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "IngredientListGet");
            cmd.Parameters["@RecipeId"].Value = RecipeId;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }

        public static DataTable GetStepsList(int RecipeId)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "StepListGet");
            cmd.Parameters["@RecipeId"].Value = RecipeId;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);

        }
        public static DataTable GetCuisineTypeList(bool IncludeBlank = false)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "CuisineTypeGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = IncludeBlank;
            return CPUFramework.SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }
        public static DataTable GetUserNameList(bool IncludeBlank = false)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "UserNameGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = IncludeBlank;
            return CPUFramework.SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }
     
    }
}


