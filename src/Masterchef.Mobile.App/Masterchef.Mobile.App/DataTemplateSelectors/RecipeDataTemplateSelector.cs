using Masterchef.Mobile.App.Models;
using Masterchef.Mobile.App.ViewCells;
using Xamarin.Forms;

namespace Masterchef.Mobile.App.DataTemplateSelectors
{
    public class RecipeDataTemplateSelector : DataTemplateSelector
    {
        DataTemplate recipeTemplate;
        DataTemplate recommendedTemplate;

        public RecipeDataTemplateSelector()
        {
            recipeTemplate = new DataTemplate(typeof(RecipeCell));
            recommendedTemplate = new DataTemplate(typeof(RecommendedRecipeCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var recipe = item as Recipe;

            if (recipe == null)
                return null;

            return recipe.IsRecommended ? recommendedTemplate : recipeTemplate;
        }
    }
}
