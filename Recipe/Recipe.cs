using Cookie_Cookbook.Ingredients;

namespace Cookie_Cookbook.Recipes
{
    public class Recipe
    {
        public List<Ingredient> Ingredients { get; }

        public Recipe(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
        public override string ToString()
        {
            var steps = new List<string>();
            foreach (var ingredient in Ingredients)
            {
                steps.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
            }

            return string.Join(Environment.NewLine, steps);
        }
    }
}