using Cookie_Cookbook.Ingredients;
using Cookie_Cookbook.Recipes;
using Cookie_Cookbook.UserInterface;

namespace Cookie_Cookbook.App
{
    public class CookieCookApp
    {
        private readonly IUserInterface _iUserInterface;
        private readonly IConsoleUserInterface _iConsoleUserInterface;
        private readonly IRecipeRepository _iRecipeRepository;



        public CookieCookApp(IUserInterface iUserInterface,
            IConsoleUserInterface iConsoleUserInterface,
            IRecipeRepository iRecipeRepository)
        {
            _iUserInterface = iUserInterface;
            _iConsoleUserInterface = iConsoleUserInterface;
            _iRecipeRepository = iRecipeRepository;
        }

        public void Run()
        {
            _iUserInterface.PrintingExistingRecipes();
            _iUserInterface.PrintHelloScreen();

            List<Ingredient> ingredients = _iConsoleUserInterface.ReadIngredeintsFromUser();

            if (ingredients.Count > 0)
            {
                _iUserInterface.PrintAddedRecipe(ingredients);
                _iRecipeRepository.SaveRecipes(ingredients);
            }
            else
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            }

            _iConsoleUserInterface.Exit();
        }

    }
}
