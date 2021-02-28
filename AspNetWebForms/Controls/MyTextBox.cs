using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace AspNetWebForms.Controls
{
    public class MyTextBox : TextBox
    {
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }
    }
}