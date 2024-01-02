create or alter proc OverviewCountGet 
 (@Message varchar (500) = '' output) 

 as
 select Type = 'Recipes', Number = count(*) 
 from Recipe r 
 union select 'Cookbooks', count(*) 
 from Cookbook c 
 union select  'Meals', count(*) 
 from Meal m 

 go 
 exec OverviewCountGet

