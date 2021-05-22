using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebFormsWithAlpine.UI.Controls;

namespace WebFormsWithAlpine.UI
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

    public abstract class HtmlInputControlBuilder : HtmlControlBuilder
    {
        protected string PropertyName;

        protected HtmlInputControlBuilder(IHaveModel control, string propertyName)
        {
            this.PropertyName = control.GetUniquePrefix() + propertyName;
        }

        public override string Build()
        {
            this.BuiltControl.Attributes.Add("x-model", PropertyName);
            this.BuiltControl.ID = PropertyName;
            return base.Build();
        }
    }

    public class HtmlTextInputBuilder : HtmlInputControlBuilder
    {
        public HtmlTextInputBuilder(IHaveModel control, string propertyName)
            : base(control, propertyName)
        {
            this.BuiltControl = new HtmlInputText("text");
        }
    }

    public class HtmlNumberInputBuilder : HtmlInputControlBuilder
    {
        public HtmlNumberInputBuilder(IHaveModel page, string propertyName)
            : base(page, propertyName)
        {
            this.BuiltControl = new HtmlInputText("number");
        }
    }

    public class HtmlSelectBuilder : HtmlInputControlBuilder
    {
        public HtmlSelectBuilder(IHaveModel page, string propertyName)
            : base(page, propertyName)
        {
            this.BuiltControl = new HtmlSelect();
        }

        public HtmlSelectBuilder WithOptions(params (string, string)[] options)
        {
            foreach (var option in options)
            {
                var li = new ListItem();
                li.Value = option.Item1;
                li.Text = option.Item2;

                ((HtmlSelect)this.BuiltControl).Items.Add(li);
            }
            return this;
        }
    }
}
