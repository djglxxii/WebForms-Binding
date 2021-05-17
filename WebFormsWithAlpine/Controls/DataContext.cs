using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsWithAlpine.Controls
{
    [ParseChildren(false)]
    public class DataContext : WebControl
    {
        public string GetDataMethod { get; set; }
            = "GetData";

        protected override void RenderContents(HtmlTextWriter writer)
        {
            if (String.IsNullOrEmpty(GetDataMethod))
            {
                throw new ArgumentException("A GetDataMethod must be specified.");
            }
            
            var bc = this.BindingContainer;
            var method = bc.GetType().GetMethod(GetDataMethod);

            if (method == null)
            {
                throw new Exception($"No method found by the name of '{GetDataMethod}'.  Get method needs to be declared on the host control.");
            }
            
            var json = method.Invoke(bc, null);

            writer.AddAttribute("x-data", json.ToString());
            writer.RenderBeginTag("div");
            base.RenderContents(writer);
            writer.RenderEndTag();
        }
    }
}