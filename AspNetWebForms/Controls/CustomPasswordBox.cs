using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AspNetWebForms.Controls
{
    public class CustomPasswordBox : WebControl
    {
        public string Password { get; set; }

        protected override void Render(HtmlTextWriter writer)
        {
            // <div>
            writer.AddAttribute("class", this.CssClass);
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            var maskedInput = new HtmlInputPassword();
            maskedInput.Attributes.Add("x-model", "Password");
            maskedInput.ID = this.ClientID;
            maskedInput.Name = this.ClientID;
            maskedInput.Value = this.Password;
            maskedInput.RenderControl(writer);

            var unmaskedInput = new HtmlInputGenericControl();
            unmaskedInput.Attributes.Add("x-model", "Password");
            unmaskedInput.ID = this.ClientID;
            unmaskedInput.Value = this.Password;
            unmaskedInput.RenderControl(writer);

            // </div>
            writer.RenderEndTag();
            base.Render(writer);
        }
    }
}
