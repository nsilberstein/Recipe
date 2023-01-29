using NUnit.Framework;
using RecipeBizObjects;
using CPUFramework;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace RecipeTest
{
    public class Tests
    {
        string connstring = "";
        int totalrecipe = 0;
        int maxrecipeid = 0;
        int maxnumcaloriesperrec = 0;
        int maxuseridval = 0;
        int maxcuisinetypeidval = 0;
        string maxrecipename = "";

        [SetUp]
        public void Setup()
        {
            connstring = DataUtility.SetConnectionString("nsilberstein.database.windows.net,1433", "RecipeDB", "nsilbersteinadmin", "CPU123!@#");
            DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*) from recipe");
            totalrecipe = (int)dt.Rows[0]["total"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.RecipeId, r.NumCaloriesPerServing from Recipe r order by r.NumCaloriesPerServing desc");
            maxrecipeid = (int)dt.Rows[0]["RecipeId"];
            maxnumcaloriesperrec = (int)dt.Rows[0]["NumCaloriesPerServing"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.CreatedByUserId from Recipe r order by r.CreatedByUserId desc");
            maxuseridval = (int)dt.Rows[0]["CreatedByUserId"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.CuisineTypeId from Recipe r order by r.CuisineTypeId desc");
            maxcuisinetypeidval = (int)dt.Rows[0]["CuisineTypeId"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.RecipeName from Recipe r");
            maxrecipename = dt.Rows[0]["RecipeName"].ToString();
        }

        //[Test]
        //public void TestRecipeList()
        //{
        //    DataTable dt = DataService.GetRecipeList();
        //    TestContext.WriteLine("Num recipes = " + dt.Rows.Count.ToString());
        //    Assert.IsTrue(dt.Rows.Count == totalrecipe);
        //    Assert.Pass();
        //}

        //[Test]
        //public void TestLoadRecipe()
        //{
        //    BizRecipe r = BizRecipe.Get(maxrecipeid);
        //    TestContext.WriteLine("Full Description = " + r.FullDescription());
        //    Assert.IsTrue(r.NumCaloriesPerServing == maxnumcaloriesperrec);           
        //}
        //[Test]
        //public void TestNewRecipe()
        //{
        //    BizRecipe r = new BizRecipe();
        //    r.CreatedByUserId = maxuseridval;
        //    r.CuisineTypeId = maxcuisinetypeidval;
        //    r.RecipeName = maxrecipename + r.RecipeId++;
        //    r.NumCaloriesPerServing = maxnumcaloriesperrec;
        //    r.NumofIngredients = 5;
        //    r.NumofSteps = 2;
        //    r.Save();
        //    TestContext.WriteLine("New Recipe num calories = " + r.NumCaloriesPerServing.ToString());
       //     Assert.IsTrue(r.NumCaloriesPerServing == maxnumcaloriesperrec);
       // }

       //[Test]
       //public void TestLoadPresidentDapper()
       // {
       //     using (SqlConnection conn = new SqlConnection(connstring))
       //     {
       //         BizRecipe r = conn.QueryFirstOrDefault<BizRecipe>("select top 1 * from Recipe  order by RecipeId");
       //         TestContext.WriteLine(r.FullDescription());
       //     }
       // }
  

    }
}