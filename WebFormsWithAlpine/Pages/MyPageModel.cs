using System.Collections.Generic;
using WebFormsWithAlpine.Controls;

namespace WebFormsWithAlpine.Pages
{
    public class MyPageModel
    {
        [RequiresUniqueIdPrefix]
        public string Firstname { get; set; }

        [RequiresUniqueIdPrefix]
        public string Lastname { get; set; }

        [RequiresUniqueIdPrefix]
        public int Zipcode { get; set; }

        [RequiresUniqueIdPrefix]
        public string Gender { get; set; }

        [RequiresUniqueIdPrefix]
        public List<(int, string)> GenderOptions = new List<(int, string)>();
    }
}