using Cookie_Cookbook.Ingredients;

namespace CookieCookbook.Recipes.Ingredients;

public interface IIngredientsRegister
{
    Ingredient GetById(int id);
}

public class IngredientsRegister : IIngredientsRegister
{
    public List<Ingredient> allIngredeints { get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new CoconutFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamom(),
        new CocaPowder()
    };

    public Ingredient GetById(int id) =>
        allIngredeints.FirstOrDefault(ingredeint => ingredeint.ID == id);
}

