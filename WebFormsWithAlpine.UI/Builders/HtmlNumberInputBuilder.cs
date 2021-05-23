using System.Web.UI.HtmlControls;
using WebFormsWithAlpine.UI.Controls;

namespace WebFormsWithAlpine.UI.Builders
{
    public class HtmlNumberInputBuilder : HtmlInputControlBuilder
    {
        public HtmlNumberInputBuilder(IHaveUniquePrefix control, string propertyName)
            : base(control, propertyName)
        {
            this.BuiltControl = new HtmlInputText("number");
        }
    }
}