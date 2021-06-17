using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace WebFormsWithAlpine.Controls
{
    public class MaskedInputControl : HtmlInputGenericControl
    {
        public bool IsMasked { get; set; } = true;

        protected override void Render(HtmlTextWriter writer)
        {
            if (IsMasked)
            {
                writer.AddAttribute("is-masked", null);
            }

            writer.AddAttribute("name", this.UniqueID);
            writer.AddAttribute("x-model", this.UniqueID);

            writer.AddAttribute("value", this.Value);
            
            writer.RenderBeginTag("aeg-masked-input");
            writer.RenderEndTag();
        }
    }
}