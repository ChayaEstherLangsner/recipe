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
            //AF Before moving forward, it would be good to have a line that checks that the recipeid is > 0, so the test won't run if there are no recipes
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select RecipeCalories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.WriteLine("change calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeCalories"] = calories;
            Recipe.Save(dt);
            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select recipecalories from recipe where recipeid = " + recipeid);
            //AF The message here if the test fails seems to be a mistake, please change it to a clear message
            Assert.IsTrue(newcalories == calories, "termstart for president (" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("calories for recipe (" + recipeid + ") = " + newcalories);
        }

        [Test]
        public void DeleteRecipe()
        {
            /*AF I understand that you only want this test to delete a recipe that was inserted from the test above with a date in
             it, just letting you know that if you run all the tests at once, this one won't necessarily work.
            When I pressed run all tests, this one didn't work because there had been no recipe records with a date inserted yet
            It's fine as is, just be aware this test might not always work*/
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
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeID();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Exsiting recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + "<>" + recipeid);
            //AF This message repeats itself, the id should be printed once since the proper id was loaded
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