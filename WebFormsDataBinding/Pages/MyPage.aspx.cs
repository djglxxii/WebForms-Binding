using System;
using WebFormsDataBinding.Infrastructure;

namespace WebFormsDataBinding.Pages
{
    public partial class MyPage : System.Web.UI.Page
    {
        protected MyPageModel Model { get; } = new MyPageModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                var provider = new CustomFormsValueProvider(ModelBindingExecutionContext);
                TryUpdateModel(Model, provider);

                if (ModelState.IsValid)
                {
                    // ModelState will be invalid due to trying to bind the value 'on' to IsMarried bool.
                }
            }

            DataBind();
        }
    }
}