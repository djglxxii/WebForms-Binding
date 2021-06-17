using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebFormsWithAlpine.Controls
{
    [ParseChildren(false)]
    public class ValidationMessageControl : WebControl
    {
        public string Message { get; set; }

        public ValidationMessagePosition Position { get; set; }
            = ValidationMessagePosition.Bottom;

        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.RenderBeginTag("aeg-validation-message");
            base.RenderBeginTag(writer);
        }

        public override void RenderControl(HtmlTextWriter writer)
        {
            if (Position == ValidationMessagePosition.Top)
            {
                writer.AddAttribute("position", "top");
            }

            writer.AddAttribute("message", Message);
            base.RenderControl(writer);
        }

        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();
            base.RenderEndTag(writer);
        }
    }

    public enum ValidationMessagePosition
    {
        Top,
        Bottom
    }
}