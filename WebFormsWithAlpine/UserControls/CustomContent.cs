using System;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsWithAlpine.UserControls
{
    public class CustomContent : Content
    {
        public string GetJsonDataMethod { get; set; }

        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
        }

        public override void RenderControl(HtmlTextWriter writer)
        {
            if (!String.IsNullOrEmpty(GetJsonDataMethod))
            {
                var method = this.Page.GetType().GetMethod(GetJsonDataMethod);
                Debugger.Break();
            }
            base.RenderControl(writer);
        }
    }
}