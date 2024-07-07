namespace cookiesRecipe.Recipes.Ingredients
{
    public abstract class Spice : Ingredient
    {
        public override string PreparationInstrucsions =>
            $"Take half a teaspoon. {base.PreparationInstrucsions}";
    }

}
