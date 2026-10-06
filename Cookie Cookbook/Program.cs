using Cookie_Cookbook.App;
using Cookie_Cookbook.Ingredients;
using Cookie_Cookbook.Recipes;
using Cookie_Cookbook.UserInterface;
using CookieCookbook.Recipes.Ingredients;



IngredientsRegister ingredientsRegister = new IngredientsRegister();
RecipeRepository recipeRepository = new RecipeRepository();

ConsoleUserInterface consoleUserInterface = new ConsoleUserInterface(ingredientsRegister);
UserInterface userInterface = new UserInterface(ingredientsRegister, recipeRepository);

CookieCookApp cookieCookApp = new CookieCookApp(userInterface,
    consoleUserInterface,
    recipeRepository);

cookieCookApp.Run();