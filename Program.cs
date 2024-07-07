

using cookiesRecipe.App;
using cookiesRecipe.DataAccess;
using cookiesRecipe.FileAccess;
using cookiesRecipe.Recipes;
using cookiesRecipe.Recipes.Ingredients;

const FileFormat Format = FileFormat.Json;

IStringRepository stringRepository = Format == FileFormat.Json ?
    new StringJsonRepository() : new StringTextualRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetadata(FileName, Format);

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipiesRepository(
        stringRepository,
        ingredientsRegister), 
    new RecipesConsoleUserInteraction(
        ingredientsRegister));
cookiesRecipesApp.Run(fileMetadata.ToPath());






