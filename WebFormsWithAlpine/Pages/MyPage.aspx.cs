using System;
using System.Web.UI;
using Newtonsoft.Json;

namespace WebFormsWithAlpine.Pages
{
    public partial class MyPage : AbstractPage<MyPageModel>
    {
        protected override MyPageModel GetData()
        {
            var model = new MyPageModel();
            model.Firstname = "David";
            model.Lastname = "Gardner";
            model.Zipcode = 22963;

            return model;
        }
    }

    public class MyPageModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Zipcode { get; set; }
    }
}