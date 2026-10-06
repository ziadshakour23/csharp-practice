namespace Cookie_Cookbook.Ingredients
{
    public class Cinnamom : Ingredient
    {
        public override int ID => 7;
        public override string Name => "Cinnamom";
        public override string PreparationInstructions =>
            $"Take half a teaspoon. {base.PreparationInstructions}";

    }
}
