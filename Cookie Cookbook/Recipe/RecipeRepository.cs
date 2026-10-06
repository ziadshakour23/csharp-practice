using Cookie_Cookbook.Ingredients;

namespace Cookie_Cookbook.Recipes
{
    public interface IRecipeRepository
    {
        void SaveRecipes(List<Ingredient> selectedIngredients);
        List<string> LoadRecipes();
    }

    public class RecipeRepository : IRecipeRepository
    {
        private const string FilePath = "Recipes.txt";

        public void SaveRecipes(List<Ingredient> selectedIngredients)
        {
            string recipeToSave = "";

            for (int i = 0; i < selectedIngredients.Count; i++)
            {
                recipeToSave += selectedIngredients[i].ID;

                if (i < selectedIngredients.Count - 1)
                {
                    recipeToSave += ", ";
                }
            }

            File.AppendAllText(FilePath, recipeToSave + Environment.NewLine);
        }

        public List<string> LoadRecipes()
        {
            List<string> result = new List<string>();

            if (!File.Exists(FilePath))
            {
                return result;
            }

            return File.ReadLines(FilePath)
                .Where(line => !string.IsNullOrEmpty(line))
                .ToList();
        }
    }
}
