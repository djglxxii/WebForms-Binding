using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsWithAlpine.Controls
{
    [ParseChildren(false)]
    public class DataContext : WebControl
    {
        protected override void RenderContents(HtmlTextWriter writer)
        {
            var bc = this.BindingContainer;
            var method = bc.GetType().GetMethod("GetData");

            var json = method.Invoke(bc, null);

            writer.AddAttribute("x-data", json.ToString());
            writer.RenderBeginTag("div");
            base.RenderContents(writer);
            writer.RenderEndTag();
        }
    }
}