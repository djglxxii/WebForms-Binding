namespace WebFormsWithAlpine.UI.Controls
{
    public interface IHaveModel<TModel> : IHaveUniquePrefix where TModel : class, new()
    {
        TModel Model { get; }
    }
}
