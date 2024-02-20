--AF Great! 100%
use RecipeDB
go
drop table if exists RecipeMealCourse
drop table if exists MealCourse
drop table if exists Meal 
drop table if exists Course 
drop table if exists RecipeInstruction
drop table if exists RecipeIngredient
drop table if exists RecipeCookbook
drop table if exists Cookbook
drop table if exists Recipe 
drop table if exists Ingredient 
drop table if exists Measurement 
drop table if exists Users
drop table if exists Cuisine

go 

create table dbo.Users
(

    UsersID int not null identity primary key, 
    UserFirstName varchar (35) not null 
        constraint ck_UserFirstName_cannot_be_blank check (UserFirstName <> ''),
    UserLastName varchar (35) not null 
        constraint ck_UserLastName_cannot_be_blank check (UserLastName <> ''),
    UserName varchar (20) not null 
        constraint ck_UserName_cannot_be_blank check (UserName <> '')
        constraint u_UserName unique 
)

create table dbo.Measurement 
(
    MeasurementID int not null identity primary key,
    MeasurementType varchar (30)
    constraint ck_MeasurementType_cannot_be_blank check (MeasurementType <> '')
    constraint u_MeasurementType unique
)

create table dbo.Cuisine 
(
    CuisineID int not null identity primary key,
    CuisineType varchar (30) not null
        constraint ck_CuisineType_cannot_be_blank check (CuisineType <> '')
        constraint u_CuisineType unique
)

create table dbo.Ingredient 
(
    IngredientID int not null identity primary key,
    IngredientName varchar (35) not null
        constraint ck_IngredientName_cannot_be_blank check (IngredientName <> '')
        constraint u_IngredientName unique,
    IngredientPicture as concat ('Ingredient-', replace (IngredientName, ' ', '-'), '.jpg') persisted
)

create table dbo.Recipe
(
    RecipeID int not null identity primary key,  
    UsersID int not null constraint f_User_Recipe foreign key references Users(UsersID),
    CuisineID int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineID),
    RecipeName varchar (50) not null 
        constraint ck_RecipeName_cannot_be_blank check (RecipeName <> '')
        constraint u_RecipeName unique,
    RecipeCalories int not null 
        constraint ck_RecipeCalories_Must_Be_greater_than_zero check (RecipeCalories > 0),
    RecipeDateDrafted datetime default getdate() not null
        constraint ck_DateDrafted_must_be_equal_to_or_less_than_the_current_date check (RecipeDateDrafted <= Getdate()),
    RecipeDatePublished datetime null
	constraint ck_DatePublished_must_be_equal_to_or_less_than_the_current_date check (RecipeDatePublished <= Getdate()),
    RecipeDateArchived datetime null
	constraint ck_DateArchived_must_be_equal_to_or_less_than_the_current_date check (RecipeDateArchived <= Getdate()),
    RecipeStatus as case 
        when RecipeDatePublished is null and RecipeDateArchived is null then 'Drafted'
        when RecipeDatePublished is not null and RecipeDateArchived is null then 'Published'
        else 'Archived' end persisted,
    RecipePicture as concat ('Recipe-', replace (RecipeName, ' ', '-'), '.jpg') persisted,
        constraint ck_RecipeDatePublished_Must_be_between_DateDrafted_and_DateArchived check (RecipeDatePublished between RecipeDateDrafted and RecipeDateArchived)
)

create table dbo.Cookbook
(
    CookbookID int not null identity primary key, 
    UsersID int not null constraint f_Users_Cookbook foreign key references Users(UsersID),
    CookbookName varchar (35) not null 
        constraint ck_CookbookName_cannot_be_blank check (CookbookName <> '')
        constraint u_CookbookName unique,
    CookbookPrice decimal (5,2) not null 
        constraint ck_CookbookPrice_must_be_greater_than_zero check (CookbookPrice > 0),
    IsActive bit not null, 
    CookbookDateInserted datetime default getdate() not null 
        constraint ck_CookbookDateInserted_must_be_equal_or_less_than_the_current_date check (CookbookDateInserted <= getdate()),
    CookbookPicture as concat ('Cookbook-', replace (CookbookName, ' ', '-'), '.jpg') persisted
)

create table dbo.RecipeCookbook
(
    RecipeCookbookID int not null identity primary key,
    RecipeID int not null constraint f_Recipe_RecipeCookbook foreign key references Recipe(RecipeID),
    CookbookID int not null constraint f_Cookbook_RecipeCookbook foreign key references Cookbook(CookbookID),
    RecipeCookbookSequence int not null 
        constraint ck_RecipeCookbook_RecipeCookbookSequence_must_be_greater_than_zero check (RecipeCookbookSequence > 0)
        constraint u_RecipeCookbook_RecipeID_CookbookID unique (RecipeID, CookbookID),
        constraint u_RecipeCookbook_CookbookID_RecipeCookbookSequence unique (CookbookID, RecipeCookbookSequence)
)

create table dbo.RecipeIngredient
(
    RecipeIngredientID int not null identity primary key,
    RecipeID int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeID),
    IngredientID int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientID),
    RecipeIngredientSequence int not null 
        constraint ck_RecipeIngredientSequence_must_be_Greater_than_zero check (RecipeIngredientSequence > 0),
    MeasurementID int not null constraint f_Measurement_RecipeIngredient foreign key references Measurement(MeasurementID),
    RecipeIngredientAmount decimal (6,2)
        constraint ck_RecipeIngredientAmount_must_be_greater_than_zero check (RecipeIngredientAmount > 0),
        constraint u_RecipeIngredient_RecipeID_IngredientID unique (RecipeID, IngredientID),
        constraint u_RecipeIngredient_RecipeID_RecipeIngredientSequence unique (RecipeID, RecipeIngredientSequence)
)

create table dbo.RecipeInstruction
(
    RecipeInstructionID int not null identity primary key,
    RecipeID int not null constraint f_Recipe_RecipeInstruction foreign key references Recipe(RecipeID),
    RecipeInstructionNumber int not null 
        constraint ck_Instruction_Number_must_be_greater_than_zero check (RecipeInstructionNumber > 0),
    RecipeInstructionDesc varchar (max) not null 
        constraint ck_RecipeInstructionDesc_cannot_be_blank check (RecipeInstructionDesc <> ''),
        constraint u_RecipeInstruction_RecipeID_RecipeInstructionNumber unique (RecipeID, RecipeInstructionNumber)
)

create table dbo.Course 
(
    CourseID int not null identity primary key,
    CourseName varchar (35) not null 
        constraint ck_CourseName_cannot_be_blank check (CourseName <> '')
        constraint u_CourseName unique,
    CourseSequence int 
        constraint ck_CourseSequence_must_be_greater_than_zero check (CourseSequence> 0)
        constraint u_CourseSequence unique
)

create table dbo.Meal 
(
    MealID int not null identity primary key,
    UsersID int not null constraint f_User_Meal foreign key references Users(UsersID),
    MealName varchar (35) not null 
        constraint ck_MealName_cannot_be_blank check (MealName <> '')
        constraint u_MealName unique,
    IsActive bit not null,
    MealDateInserted datetime default getdate() not null 
        constraint ck_MealDateInserted_must_be_less_than_or_equal_to_the_current_date check (MealDateInserted <= getdate()),
    MealPicture as concat ('Meal-', replace (MealName, ' ', '-'), '.jpg') persisted
)

create table dbo.MealCourse
(
        MealCourseID int not null identity primary key,
        MealID int not null constraint f_Meal_MealCourse foreign key references Meal(MealID),
        CourseID int not null constraint f_Course_MealCourse foreign key references Course(CourseID),
            constraint u_MealCourse_MealID_CourseID unique (MealID, CourseID)
)

create table dbo.RecipeMealCourse
(
    RecipeMealCourse int not null identity primary key,
    MealCourseID int not null constraint f_MealCourse_RecipeMealCourse foreign key references MealCourse(MealCourseID),
    RecipeID int not null constraint f_Recipe_RecipeMealCourse foreign key references Recipe(RecipeID),
    IsMainDish bit not null,
        constraint u_RecipeMealCourse_MealCourseID_RecipeID unique (MealCourseID, RecipeID)
)
