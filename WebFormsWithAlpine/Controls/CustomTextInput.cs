using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace WebFormsWithAlpine.Controls
{
    public class CustomTextInput : HtmlInputText
    {
        public override void RenderControl(HtmlTextWriter writer)
        {
            this.Attributes.Add("x-model", this.ID);
            base.RenderControl(writer);
        }
    }
}