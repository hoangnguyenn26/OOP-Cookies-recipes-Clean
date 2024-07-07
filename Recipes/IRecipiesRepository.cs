using static cookiesRecipe.Recipes.RecipiesRepository;

namespace cookiesRecipe.Recipes
{
    public interface IRecipiesRepository
    {
        List<Recipe> Read(string filePath);
        void Write(string filePath, List<Recipe> allRecipes);
    }
}
