using cookiesRecipe.Recipes;


namespace cookiesRecipe.App
{
    public class CookiesRecipesApp
    {
        private readonly IRecipiesRepository _recipiesRepository;
        private readonly IRecipesUserInteraction _recipiesUserInteraction;

        public CookiesRecipesApp(IRecipiesRepository recipiesRepository,
            IRecipesUserInteraction recipiesUserInteraction)
        {
            _recipiesRepository = recipiesRepository;
            _recipiesUserInteraction = recipiesUserInteraction;
        }
        public void Run(string filePath)
        {
            var allRecipes = _recipiesRepository.Read(filePath);
            _recipiesUserInteraction.PrintExistingRecipes(allRecipes);

            _recipiesUserInteraction.PromptToCreatRecipes();

            var ingredients = _recipiesUserInteraction.ReadIngredientsFromUser();
            if (ingredients.Count() > 0)
            {
                var recipe = new Recipe(ingredients);
                allRecipes.Add(recipe);
                _recipiesRepository.Write(filePath, allRecipes);

                _recipiesUserInteraction.ShowMessage("Recipe added:");
                _recipiesUserInteraction.ShowMessage(recipe.ToString());
            }
            else
            {
                _recipiesUserInteraction.ShowMessage(
                    "No ingredients have been selected." +
                    "Recipe will not be saved.");
            }

            _recipiesUserInteraction.Exit();
        }
    }
}
