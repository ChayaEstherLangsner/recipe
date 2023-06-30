using System.Data;

namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecipeDB;Trusted_Connection=true");
        }
        [Test]
        [TestCase("spongecake", 1000, "2023-1-1")]
        [TestCase("sugarcookie", 2000, "2023-1-2")]
        public void InsertNewRecipe(string name, int calories, DateTime datedrafted)
        {
            DataTable dt = SQLUtility.GetDataTable("select RecipeID, RecipeName, UsersID, CuisineID, RecipeCalories, RecipeDateDrafted from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int userid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(userid > 0, "Can't run test, no users in the DB");
            Assume.That(cuisineid > 0, "Can't run test, no cuisines in the DB");
            name = name + " " + DateTime.Now;
            TestContext.WriteLine("insert recipe with name = " + name);
            r["RecipeName"] = name;
            r["UsersID"] = userid;
            r["CuisineID"] = cuisineid;
            r["RecipeCalories"] = calories;
            r["RecipeDateDrafted"] = datedrafted;
            Recipe.Save(dt);
            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where RecipeName = '" + name + "'");
            Assert.IsTrue(newid > 0, "recipe with name = " + name + "is not found in DB");
            TestContext.WriteLine("recipe with " + name + " is found in db with pk value = " + newid);
        }
         
        [Test]
        public void ChangeExistingRecipecalories()
        {
            int recipeid = GetExistingRecipeID();
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select RecipeCalories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.WriteLine("change calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeCalories"] = calories;
            Recipe.Save(dt);
            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select recipecalories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "calories for recipe (" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("calories for recipe (" + recipeid + ") = " + newcalories);
        }
        [Test]
        public void ChangeExistingRecipecaloriesToInvalidNum()
        {
            int recipeid = GetExistingRecipeID();
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select RecipeCalories from recipe where recipeid = " + recipeid);
            int newcalories = 0;
            TestContext.WriteLine("change calories for recipeid " + recipeid + " from "+calories + " to " + newcalories);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeCalories"] = newcalories;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt), "RecipeCalories Must Be greater than zero");
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void ChangeExistingRecipeDateDraftedToInvalidDate()
        {
            int recipeid = GetExistingRecipeID();
            string date = SQLUtility.GetFirstColumnFirstRowValueAsString("select RecipeDateDrafted from recipe where recipeid = " + recipeid);
            DateTime newdate = DateTime.Now.AddDays(1);
            TestContext.WriteLine("change date drafted for recipeid " + recipeid + " from " + date + " to " + newdate);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeDateDrafted"] = newdate;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt), "DateDrafted must be equal to or less than then current date");
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void ChangeExistingRecipeNameToExistingName()
        {
            int recipeid = GetExistingRecipeID();
            string name = SQLUtility.GetFirstColumnFirstRowValueAsString("select RecipeName from recipe where recipeid = " + recipeid);
            string newname = SQLUtility.GetFirstColumnFirstRowValueAsString("select RecipeName from recipe where recipeid <> " + recipeid);
            TestContext.WriteLine("change date drafted for recipeid " + recipeid + " from " + name + " to " + newname);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = newname;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt), "RecipeName must be unique");
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 recipeid, recipename, recipecalories from Recipe r where RecipeName like '%2023%'");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipename"] + " " + dt.Rows[0]["recipecalories"];
            }
            Assume.That(recipeid > 0, "No recipes with a date in DB, can't run test");
            TestContext.WriteLine("Exsiting recipe with a date, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }
        [Test]
        public void DeleteRecipeWithRecipeIngredient()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.RecipeID, RecipeName, RecipeCalories from Recipe r join RecipeIngredient i on r.RecipeID = i.RecipeID");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["RecipeCalories"];
            }
            Assume.That(recipeid > 0, "No recipes with recipe  ingredients in DB, can't run test");
            TestContext.WriteLine("Exsiting recipe with recipe ingredients, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app cannot delete recipeid " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeID();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Exsiting recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + "<>" + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ") " + recipeid);
        }
        [Test]
        public void GetListOfUsers()
        {
            int userscount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from users");
            Assume.That(userscount > 0, "No users in DB, can't test");
            TestContext.WriteLine("Num of users in DB = " + userscount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + userscount);
            DataTable dt = Recipe.GetUserList();
            Assert.IsTrue(dt.Rows.Count == userscount, "Num rows return by app (" + dt.Rows.Count + ") <>" + userscount);
            TestContext.WriteLine("Number of rows in users returned by app = " + dt.Rows.Count);
        }
        [Test]
        public void GetListOfCuisines()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No cuisines in DB, can't test");
            TestContext.WriteLine("Num of cuisines in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + cuisinecount);
            DataTable dt = Recipe.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "Num rows return by app (" + dt.Rows.Count + ") <>" + cuisinecount);
            TestContext.WriteLine("Number of rows in cuisines returned by app = " + dt.Rows.Count);
        }
        private int GetExistingRecipeID()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 Recipeid from recipe");
        }
    }
}