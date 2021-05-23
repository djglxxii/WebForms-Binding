namespace WebFormsWithAlpine.UI.Controls
{
    public interface IHaveModel<TModel> : IModelControl where TModel : class, new()
    {
        TModel Model { get; }
    }
}
