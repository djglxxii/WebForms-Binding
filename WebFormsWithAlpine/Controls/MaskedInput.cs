using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace WebFormsWithAlpine.Controls
{
    public class MaskedInput : HtmlInputGenericControl
    {
        public bool IsVisible { get; set; } = false;

        protected override void Render(HtmlTextWriter writer)
        {
            if (IsVisible)
            {
                writer.AddAttribute("is-visible", null);
            }

            writer.AddAttribute("name", this.UniqueID);
            writer.AddAttribute("x-model", this.UniqueID);

            writer.AddAttribute("value", this.Value);
            
            writer.RenderBeginTag("aeg-masked-input");
            writer.RenderEndTag();
        }
    }
}