using System;
using System.Diagnostics;
using System.Web.UI.WebControls;

namespace AspNetWebForms.Controls
{
    public class MyButton : Button
    {
        protected override void OnLoad(EventArgs e)
        {
            Debugger.Break();
            base.OnLoad(e);
        }
    }
}