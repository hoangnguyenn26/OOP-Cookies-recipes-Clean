namespace cookiesRecipe.Recipes.Ingredients
{
    public class Chocolate : Ingredient
    {
        public override int Id => 4;
        public override string Name => "Chocolate";
        public override string PreparationInstrucsions =>
            $"Melt in a water bath. {base.PreparationInstrucsions}";
    }

}
