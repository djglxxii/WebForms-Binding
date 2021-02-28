using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetWebForms.Pages
{
    public partial class MyPage2 : System.Web.UI.Page
    {
        public MyPage2Model Model { get; private set; } = new MyPage2Model();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }

    public class MyPage2Model
    {
        [Required]
        public string Tab1Text { get; set; } = "abc";
        [Required]
        public string Tab2Text { get; set; } = "def";
        [Required]
        public string Tab3Text { get; set; } = "ghi";

        [Required] public string MyPassword { get; set; } = "password1";

    }
}