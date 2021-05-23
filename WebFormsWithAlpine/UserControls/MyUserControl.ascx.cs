using WebFormsWithAlpine.UI.Controls;

namespace WebFormsWithAlpine.UserControls
{
    public partial class MyUserControl : UserControlWithModel<MyUserControlModel>
    {
        protected override void LoadData()
        {
            this.Model = new MyUserControlModel
            {
                SomeInfo1 = "zah1",
                SomeInfo2 = "zah2"
            };
        }
    }
}