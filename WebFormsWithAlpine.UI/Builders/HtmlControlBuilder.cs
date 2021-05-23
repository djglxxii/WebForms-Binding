using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace WebFormsWithAlpine.UI.Builders
{
    public abstract class HtmlControlBuilder
    {
        private readonly List<string> _cssClasses = new List<string>();

        protected HtmlControl BuiltControl;

        public HtmlControlBuilder WithCssClass(string cssClass)
        {
            if (_cssClasses.Any())
            {
                BuiltControl.Attributes.Add("class", String.Join(" ", _cssClasses));
            }
            return this;
        }

        public virtual string Build()
        {
            var tr = new StringWriter();
            var writer = new HtmlTextWriter(tr);
            BuiltControl.RenderControl(writer);

            return tr.ToString();
        }
    }
}
