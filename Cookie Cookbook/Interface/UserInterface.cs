using Cookie_Cookbook.Ingredients;
using Cookie_Cookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace Cookie_Cookbook.UserInterface
{

    public interface IUserInterface
    {
        void PrintHelloScreen();
        void PrintingExistingRecipes();
        void PrintAddedRecipe(List<Ingredient> ingredients);
    }

    public class UserInterface : IUserInterface
    {
        private readonly IIngredientsRegister _ingredientsRegister;
        private readonly IRecipeRepository _irepository;
        public UserInterface(IIngredientsRegister iIngredientsRegister
            , IRecipeRepository irepository)
        {
            _ingredientsRegister = iIngredientsRegister;
            _irepository = irepository;
        }

        public void PrintHelloScreen()
        {
            Console.WriteLine("Create a new cookie recipe!" +
                "Available ingredients are:");
            Console.WriteLine("1. Wheat flour");
            Console.WriteLine("2. Coconut flour");
            Console.WriteLine("3. Butter");
            Console.WriteLine("4. Chocolate");
            Console.WriteLine("5. Sugar");
            Console.WriteLine("6. Cardamom");
            Console.WriteLine("7. Cinnamon");
            Console.WriteLine("8. Coca powder");
        }

        public void PrintingExistingRecipes()
        {
            List<string> recipes = _irepository.LoadRecipes();

            if (recipes.Count > 0)
            {
                Console.WriteLine("Existing recipes are:");
                Console.WriteLine();

                int recipeNumber = 1;

                foreach (string recipe in recipes)
                {
                    Console.WriteLine($"***** {recipeNumber} *****");

                    PrintRecipeIngredients(recipe);
                    Console.WriteLine();
                    recipeNumber++;
                }
            }
        }

        private void PrintRecipeIngredients(string recipe)
        {
            var ingredientIdsAsText = recipe.Split(", ");

            var ingredientIdsAsInts = ingredientIdsAsText
                .Select(textId => int.Parse(textId));

            var ingredients =
                ingredientIdsAsInts.Select(id => _ingredientsRegister.GetById(id))
                .Where(ingredient => ingredient is not null);

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}. {ingredient.PreparationInstructions}");
            }
        }



        public void PrintAddedRecipe(List<Ingredient> ingredients)
        {
            Console.WriteLine("Recipe Added!");

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}. {ingredient.PreparationInstructions}");
            }
        }
    }
}