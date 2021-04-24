using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace WebFormsWithAlpine.UserControls
{
    public class CustomInputText : HtmlInputText
    {
        public override void RenderControl(HtmlTextWriter writer)
        {
            this.Attributes.Add("x-model", this.ID);
            base.RenderControl(writer);
        }
    }
}