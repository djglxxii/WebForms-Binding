using System;
using System.Web.UI;

namespace WebFormsWithAlpine.UserControls
{
    public class AbstractControl<TModel> : UserControl where TModel : class, new()
    {
        protected TModel Model { get; set; } = new TModel();

        protected bool TryUpdateMyModel()
        {
            throw new NotImplementedException();
        }
    }
}

