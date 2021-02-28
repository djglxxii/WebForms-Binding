using System;

namespace AspNetWebForms.UserControls
{
    public partial class MyUserControl : System.Web.UI.UserControl
    {
        public string MyButtonText { get; } = "MyBVutton Te4xrt";

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
