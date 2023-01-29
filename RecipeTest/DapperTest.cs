using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using RecipeBizObjects;
using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeTest
{
    internal class DapperTest
    {
        string connstring = "";
        int totalrecipe = 0;
        int maxrecipeid = 0;
        int maxnumcaloriesperrec = 0;
        int maxcuisinetypeid = 0;
        int maxuserid = 0;
        [SetUp]

        public void Setup()
        {
          
            connstring = DataUtility.SetConnectionString("nsilberstein.database.windows.net,1433", "RecipeDB", "nsilbersteinadmin", "CPU123!@#");
            DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*) from recipe");
            totalrecipe = (int)dt.Rows[0]["total"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.RecipeId, r.NumCaloriesPerServing from Recipe r order by r.NumCaloriesPerServing desc");
            maxrecipeid = (int)dt.Rows[0]["RecipeId"];
            maxnumcaloriesperrec = (int)dt.Rows[0]["NumCaloriesPerServing"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.CuisineTypeId from Recipe r");
            maxcuisinetypeid = (int)dt.Rows[0]["CuisineTypeId"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.CreatedByUserId from Recipe r");
            maxuserid = (int)dt.Rows[0]["CreatedByUserId"];

        }
        private List<BizRecipe> LoadListRecipes()
        {
            return BizRecipe.GetAll();
        }

        private BizRecipe LoadRecipe(int Id)
        {
            BizRecipe r = BizRecipe.Get(Id);
            return r;
        }

        private BizRecipe InsertNewRecipe()
        {
            BizRecipe r = new BizRecipe();
            r.CuisineTypeId = maxcuisinetypeid;
            r.CreatedByUserId = maxuserid;
            r.RecipeName = "Blueberry Pie";
            r.NumCaloriesPerServing = maxnumcaloriesperrec;
            r.DateCreated = DateTime.Now;
            r.DatePublished = null;
            r.DateArchived = null;
            r.Save();
            return r;
        }
        
    private void UpperRecipeName(BizRecipe r)
        {
            string uppername = r.RecipeName.ToUpper();
            r.RecipeName = uppername;
            r.Save();
        }

        private int DeleteRecipe(int Id = 0)
        {
            BizRecipe r;
            if (Id == 0)
            {
                r = this.InsertNewRecipe();
            }
            else
            {
                r = this.LoadRecipe(Id);
            }
            Id = r.RecipeId;
            r.Delete();
            return Id;
        }





        [Test]
        public void TestLoadListRecipe()
        {
            List<BizRecipe> lst = this.LoadListRecipes();
            Assert.IsTrue(lst.Count == totalrecipe);
            TestContext.WriteLine("num of recipes = " + lst.Count);
        }

        [Test]
        public void TestLoadRecipe()
        {
            BizRecipe r = this.LoadRecipe(maxrecipeid);
            TestContext.WriteLine(r.FullDescription());
            Assert.IsTrue(r.NumCaloriesPerServing == maxnumcaloriesperrec);

        }


        [Test]
        public void TestInsertNewRecipe()
        {
            BizRecipe r = this.InsertNewRecipe();
            TestContext.WriteLine("Expected num calories " + maxnumcaloriesperrec + " and actual num = " + maxnumcaloriesperrec) ;
            Assert.IsTrue(r.NumCaloriesPerServing == maxnumcaloriesperrec);
        }

        [Test]
        public void TestUpdateRecipe()
        {
            BizRecipe r = this.LoadRecipe(maxrecipeid);
            string recipenewname = r.RecipeName.ToUpper();
            this.UpperRecipeName(r);
            r = this.LoadRecipe(maxrecipeid);
            TestContext.WriteLine("Original = " + r.RecipeName + " New = " + recipenewname);
            Assert.IsTrue(r.RecipeName == recipenewname);

        }

        [Test]
        public void TestDeleteRecipe()
        {
            int id = this.DeleteRecipe();
            BizRecipe r = this.LoadRecipe(id);
            Assert.IsTrue(r.RecipeId == 0);
        }
        
        [Test]
        public void TestSearchRecipe()
        {
            List<BizRecipe> lst = BizRecipe.Search("milk");
            TestContext.WriteLine("List count = " + lst.Count.ToString());
            Assert.IsTrue(lst.Count == 1);
        }
    }
}
