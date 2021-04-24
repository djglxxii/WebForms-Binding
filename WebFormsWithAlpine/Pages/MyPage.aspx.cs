using System;
using System.Collections.Generic;
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
            model.MyList = new List<string> {"A", "B", "C"};
            
            return model;
        }
    }

    public class MyPageModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Zipcode { get; set; }
        
        [JsonData]
        public List<string> MyList { get; set; }
            = new List<string>();
    }
}