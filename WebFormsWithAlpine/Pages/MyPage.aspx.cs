using WebFormsWithAlpine.Controls;
using WebFormsWithAlpine.Extensions;

namespace WebFormsWithAlpine.Pages
{
    public partial class MyPage : PageWithModel<MyPageModel>
    {
        protected override void LoadData()
        {
            Model = new MyPageModel();
            Model.Firstname = "David";
            Model.Lastname = "Gardner";
            Model.Zipcode = 22963;
            Model.IsMale = true;
            
            
        }
    }
}