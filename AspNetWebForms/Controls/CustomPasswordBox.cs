using System.Linq.Expressions;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AspNetWebForms.Controls
{
    public class CustomPasswordBox : WebControl
    {
        public string Password { get; set; }
        public string ShowPasswordLocalKey { get; set; } = "Show Password";

        protected override void Render(HtmlTextWriter writer)
        {
            // <div>
            writer.AddAttribute("class", this.CssClass);
            
            var showOnEnterScript = new StringBuilder();
            showOnEnterScript.Append("$refs.unmaskedInput.style='display: initial'");
            showOnEnterScript.Append(";");
            showOnEnterScript.Append("$refs.maskedInput.style='display: none'");

            var hideOnLeave = new StringBuilder();
            hideOnLeave.Append("$refs.maskedInput.style='display: initial'");
            hideOnLeave.Append(";");
            hideOnLeave.Append("$refs.unmaskedInput.style='display: none'");

            writer.AddAttribute("x-on:mouseover", showOnEnterScript.ToString());
            writer.AddAttribute("x-on:mouseout", hideOnLeave.ToString());
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            var maskedInput = new HtmlInputPassword();
            maskedInput.Attributes.Add("x-ref", "maskedInput");
            maskedInput.Attributes.Add("x-model", "Password");
            maskedInput.Name = this.ClientID;
            maskedInput.Value = this.Password;
            maskedInput.RenderControl(writer);

            var unmaskedInput = new HtmlInputGenericControl();
            unmaskedInput.Attributes.Add("x-ref", "unmaskedInput");
            unmaskedInput.Attributes.Add("x-model", "Password");
            unmaskedInput.Attributes.Add("style", "display : none");
            unmaskedInput.Name = this.ClientID;
            unmaskedInput.Value = this.Password;
            unmaskedInput.RenderControl(writer);

            // </div>
            writer.RenderEndTag();
            base.Render(writer);
        }
    }
}
