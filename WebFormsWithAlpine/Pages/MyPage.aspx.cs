using System;
using System.Web.UI;
using Newtonsoft.Json;
using WebFormsWithAlpine.Infrastructure;

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
            model.Foo = new Foo {Bar1 = "Bar One", Bar2 = "Bar Two"};
            
            return model;
        }
    }

    public class MyPageModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Zipcode { get; set; }
     
        [JsonData]
        public Foo Foo { get; set; }
    }

    public class Foo
    {
        public string Bar1 { get; set; }
        public string Bar2 { get; set; }
    }
}