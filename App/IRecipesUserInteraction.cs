using cookiesRecipe.Recipes.Ingredients;
using cookiesRecipe.Recipes;


namespace cookiesRecipe.App
{
    public interface IRecipesUserInteraction
    {
        void ShowMessage(string message);
        void Exit();
        void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
        void PromptToCreatRecipes();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
    }
}
