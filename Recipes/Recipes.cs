using cookiesRecipe.Recipes.Ingredients;

namespace cookiesRecipe.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }
        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            var steps = new List<string>();

            foreach ( var ingredient in Ingredients )
            {
                steps.Add($"{ingredient.Name}. {ingredient.PreparationInstrucsions}");
            }
            return string.Join( Environment.NewLine, steps );
        }
    }

}
