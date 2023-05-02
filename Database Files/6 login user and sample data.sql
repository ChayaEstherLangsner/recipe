
/*
Data for a recipe -
    Recipe: Mac and Cheese 
    Ingredients: 1 box macaroni, 4 cups water, pinch of salt, 5 slices of american cheese, 1/2 cup Mozerella cheese
    Cuisine: American
    Instructions: First boil water in a pot 
                  add pinch of salt
                  pour in the box of macaroni 
                  cook for 5 min or till macaroni soft
                  in seperate pot stir cheeses till melted together
                  pour the cheese into the macaroni and stir
*/

CREATE LOGIN loginname WITH password =passwordname

CREATE USER user_CPUStaff FROM LOGIN loginname

alter role db_datawriter add member [user_CPUStaff]
alter role db_datareader add member [user_CPUStaff]
