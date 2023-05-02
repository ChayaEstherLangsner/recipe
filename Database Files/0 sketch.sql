
/*
RecipeDB

Users
    UsersID pk 
    UserFirstName varchar (35)
        <> ''
    UserLastName varchar (35)
        not ''
    UserName varchar (20)
        not '', unique

Measurement
    MeasurementID pk 
    MeasurementType varchar (30)
        <> '', unique
Cuisine
    CuisineID pk 
    CuisineType varchar (30)
        <> '', unique
Ingredient 
    IngredientID pk 
    IngredientName varchar (35)
        <> '', unique
    IngredientPicture as concat ('Ingredient-', replace (IngredientName, ' ', '-'), '.jpg') persisted
Recipe
    RecipeID pk 
    UsersID fk (user)
    CuisineID fk (cuisine)
    RecipeName varchar (50)
        <> '', unique
    RecipeCalories int 
        > 0
    RecipeDateDrafted datetime default getdate() 
        <= Getdate()
    RecipeDatePublished date null
    RecipeDateArchived date null
    RecipeStatus as case 
        when RecipeDatePublished is null and RecipeDateArchived is null then Drafted
        when RecipeDatePublished is not null and RecipeDateArchived is null then Published
        else Archived end persisted
    RecipePicture as concat ('Recipe-', replace (RecipeName, ' ', '-'), '.jpg') persisted
    check (RecipeDatePublished between RecipeDateDrafted and RecipeDateArchived)
Cookbook
    CookbookID pk 
    UsersID fk (user)
    CookbookName varchar (35)
        <> '', unique
    CookbookPrice decimal (5,2)
        > 0
    IsActive bit 
    CookbookDateInserted datetime default getdate()
        <= getdate()
    CookbookPicture as concat ('Cookbook-', replace (CookbookName, ' ', '-'), '.jpg') persisted
RecipeCookbook
    RecipeCookbookID pk
    RecipeID fk (Recipe)
    CookbookID fk (Cookbook)
    RecipeCookbookSequence int
        > 0
    unique (RecipeID, CookbookID)
RecipeIngredient
    RecipeIngredientID pk
    RecipeID fk (recipe)
    IngredientID fk (ingredient)
    RecipeIngredientSequence int
        > 0
    MeasurementID fk (measurement)
    RecipeIngredientAmount decimal (6,2)
        > 0
    unique (recipe, ingredient)
    unique (RecipeID, RecipeIngredientSequence)

RecipeInstruction
    RecipeInstructionID pk 
    RecipeID fk (Recipe)
    RecipeInstructionNumber int 
        > 0
    RecipeInstructionDesc varchar (max)
        <> ''
    unique (RecipeID, InstructionNumber)
    
Course 
    CourseID pk
    CourseName varchar (35)
        <> '', unique
    CourseSequence int 
        > 0, unique
Meal 
    MealID pk 
    UsersID fk (user)
    MealName varchar (35)
        <> '', unique
    IsActive bit
    MealDateInserted datetime default getdate()
        <= getdate()
    MealPicture as concat ('Meal-', replace (MealName, ' ', '-'), '.jpg') persisted

MealCourse 
    MealCourseID pk
    MealID fk (Meal)
    CourseID fk (Course)
    unique (MealID, CourseID)

RecipeMealCourse
    RecipeMealCourse pk
    MealCourseID fk (MealCourse)
    RecipeID fk (Recipe)
    IsMainDish bit 
    unique (MealCourseID, RecipeID)





*/