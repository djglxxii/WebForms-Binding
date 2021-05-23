using System.Web.UI.HtmlControls;
using WebFormsWithAlpine.UI.Controls;

namespace WebFormsWithAlpine.UI.Builders
{
    public class HtmlTextInputBuilder : HtmlInputControlBuilder
    {
        public HtmlTextInputBuilder(IModelControl control, string propertyName)
            : base(control, propertyName)
        {
            this.BuiltControl = new HtmlInputText("text");
        }
    }
}