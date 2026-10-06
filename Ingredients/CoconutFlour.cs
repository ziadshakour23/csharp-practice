namespace Cookie_Cookbook.Ingredients
{
    public class CoconutFlour : Ingredient
    {
        public override int ID => 2;
        public override string Name => "Coconut flour";
        public override string PreparationInstructions =>
            $"Sieve. {base.PreparationInstructions}";

    }
}
