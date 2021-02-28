using System;

namespace AspNetWebForms.Pages
{
    public partial class MyPage : System.Web.UI.Page
    {
        public string ActiveTab { get;set; }

        public string Button1Text { get; } = "My Button 1";
        public string Button2Text { get; } = "My Button 2";

        protected void Page_Load(object sender, EventArgs e)
        {
            ActiveTab = "Tab 2";

            DataBind();
        }
    }
}