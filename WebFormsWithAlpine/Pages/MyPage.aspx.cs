using WebFormsWithAlpine.Controls;

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
            Model.Gender = "0";

            Model.GenderOptions.Add((0, "Male"));
            Model.GenderOptions.Add((1, "Female"));
            Model.GenderOptions.Add((3, "Other"));

            Model.Password = "pass123";
        }
    }
}