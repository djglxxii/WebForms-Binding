using System.Web.UI;
using WebFormsWithAlpine.UI.Controls;
using WebFormsWithAlpine.UI.Extensions;

namespace WebFormsWithAlpine.UI.Builders
{
    public abstract class HtmlInputControlBuilder : HtmlControlBuilder
    {
        protected string PropertyName;

        protected HtmlInputControlBuilder(IHaveUniquePrefix control, string propertyName)
        {
            PropertyName = control.GetUniquePrefix() + propertyName;
        }

        public override string Build()
        {
            this.BuiltControl.Attributes.Add("x-model", PropertyName);
            this.BuiltControl.ID = PropertyName;
            return base.Build();
        }
    }
}