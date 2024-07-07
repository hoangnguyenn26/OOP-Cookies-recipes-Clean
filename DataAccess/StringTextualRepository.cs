namespace cookiesRecipe.DataAccess
{
    public class StringTextualRepository : StringRepository
    {

        private static readonly string Separator = Environment.NewLine;

        protected override string? StringToText(List<string> strings)
        {
            return string.Join(Separator, strings);
        }

        protected override List<string> TextToString(string fileContents)
        {
            return fileContents.Split(Separator).ToList();
        }
    }
}
