namespace Cookie_Cookbook.Ingredients
{
    public class Chocolate : Ingredient
    {
        public override int ID => 4;
        public override string Name => "Chocolate";
        public override string PreparationInstructions =>
            $"Melt in a water path. {base.PreparationInstructions}";

    }
}
