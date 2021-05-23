using System.Web.ModelBinding;

namespace WebFormsWithAlpine.UI.Controls
{
    public interface IModelControl
    {
        string GetUniquePrefix();
        ModelStateDictionary GetModelState();
    }
}
