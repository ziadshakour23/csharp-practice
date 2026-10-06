namespace Cookie_Cookbook.Ingredients
{
    public class WheatFlour : Ingredient
    {
        public override int ID => 1;
        public override string Name => "Wheat flour";
        public override string PreparationInstructions =>
            $"Sieve. {base.PreparationInstructions}";

    }
}
