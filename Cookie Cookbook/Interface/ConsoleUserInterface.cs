using Cookie_Cookbook.Ingredients;
using Cookie_Cookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace Cookie_Cookbook.UserInterface
{

    public interface IConsoleUserInterface
    {
        List<Ingredient> ReadIngredeintsFromUser();
        void Exit();
    }

    public class ConsoleUserInterface : IConsoleUserInterface
    {
        private readonly IIngredientsRegister _ingredientsRegister;

        public ConsoleUserInterface(IIngredientsRegister IngredientsRegister)
        {
            _ingredientsRegister = IngredientsRegister;
        }

        public List<Ingredient> ReadIngredeintsFromUser()
        {
            List<Ingredient> ingredient = new List<Ingredient>();
            bool shallStop = false;

            while (!shallStop)
            {
                Console.WriteLine("Add an ingredient by its ID " +
                    "or type anything else if finished");
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int result))
                {
                    var selectedIngredient = _ingredientsRegister.GetById(result);
                    if (selectedIngredient is not null)
                    {
                        ingredient.Add(selectedIngredient);
                    }
                }
                else
                {
                    shallStop = true;
                }
            }
            return ingredient;
        }

        public void Exit()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
