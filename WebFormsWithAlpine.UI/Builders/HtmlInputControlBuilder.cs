using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using WebFormsWithAlpine.UI.Controls;

namespace WebFormsWithAlpine.UI.Builders
{
    public abstract class HtmlInputControlBuilder : HtmlControlBuilder
    {
        protected readonly IModelControl Control;
        protected string PropertyName;
        protected string PrefixedPropertyName;
        protected bool IncludeValidation = false;
        protected string ValidationCssClass = null;

        protected HtmlInputControlBuilder(IModelControl control, string propertyName)
        {
            Control = control;
            PropertyName = propertyName;
            PrefixedPropertyName = control.GetUniquePrefix() + propertyName;
        }

        public HtmlInputControlBuilder ShowValidation()
        {
            this.IncludeValidation = true;

            return this;
        }
        
        public override string Build()
        {
            this.BuiltControl.Attributes.Add("x-model", PrefixedPropertyName);
            this.BuiltControl.ID = PrefixedPropertyName;

            if (!IncludeValidation || !HasErrors())
            {
                return base.Build();
            }

            var sb = new StringBuilder();
            sb.Append(base.Build());

            var div = new HtmlGenericControl("div");
            if (!String.IsNullOrEmpty(ValidationCssClass))
            {
                div.Attributes.Add("class", ValidationCssClass);
            }
            div.InnerText = GetErrorMessage();

            var tr = new StringWriter();
            var writer = new HtmlTextWriter(tr);
            div.RenderControl(writer);
            sb.Append(tr);

            return sb.ToString();
        }

        private bool HasErrors()
        {
            var modelState = Control.GetModelState();
            var state = modelState[PropertyName];
            return state != null && state.Errors.Any();
        }

        private string GetErrorMessage()
        {
            var modelState = Control.GetModelState();
            var state = modelState[PropertyName];
            return state.Errors.First().ErrorMessage;
        }
    }
}