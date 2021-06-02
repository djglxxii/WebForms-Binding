using System.Collections.Generic;
using WebFormsWithAlpine.Controls;

namespace WebFormsWithAlpine.Pages
{
    public class MyPageModel
    {
        [RequiresUniquePrefix]
        public string Firstname { get; set; }

        [RequiresUniquePrefix]
        public string Lastname { get; set; }

        [RequiresUniquePrefix]
        public int Zipcode { get; set; }

        [RequiresUniquePrefix]
        public string Gender { get; set; }

        [RequiresUniquePrefix]
        public List<(int, string)> GenderOptions = new List<(int, string)>();
    }
}