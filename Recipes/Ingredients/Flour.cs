namespace cookiesRecipe.Recipes.Ingredients
{
    public abstract class Flour : Ingredient
    {
        public override string PreparationInstrucsions =>
            $"Sieve. {base.PreparationInstrucsions}";
    }

}
