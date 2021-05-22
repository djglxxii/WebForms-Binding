using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebFormsWithAlpine.UI.Extensions;

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
        protected readonly Page Page;
        protected string PropertyName;

        protected HtmlInputControlBuilder(Page page)
        {
            this.Page = page;
        }

        protected HtmlControlBuilder WithProperty(string propertyName)
        {
            this.PropertyName = propertyName;
            return this;
        }

        public override string ToString()
        {
            BuiltControl.ID = $"{Page.GetUniquePrefix()}{this.PropertyName}";
            return base.ToString();
        }
    }

    public class HtmlTextInputBuilder : HtmlInputControlBuilder
    {
        public HtmlTextInputBuilder(Page page)
            : base(page)
        {
            this.BuiltControl = new HtmlInputText("text");
        }
    }

    public class HtmlNumberInputBuilder : HtmlInputControlBuilder
    {
        public HtmlNumberInputBuilder(Page page) : base(page)
        {
            this.BuiltControl = new HtmlInputText("number");
        }
    }

    public class HtmlSelectBuilder : HtmlInputControlBuilder
    {
        public HtmlSelectBuilder(Page page) 
            : base(page)
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
