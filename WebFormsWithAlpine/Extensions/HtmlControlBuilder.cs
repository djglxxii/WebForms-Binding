using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebFormsWithAlpine.Extensions
{
    public class HtmlControlBuilder
    {
        private readonly HtmlControlType _type;
        private readonly string _propertyName;
        private readonly List<string> _classes = new List<string>();

        private HashSet<ListItem> _options = new HashSet<ListItem>();

        public HtmlControlBuilder(Page page, HtmlControlType type, string propertyName)
        {
            _type = type;
            _propertyName = $"{page.GetUniquePrefix()}{propertyName}";
        }

        public HtmlControlBuilder WithClass(string cssClass)
        {
            _classes.Add(cssClass);
            return this;
        }

        public HtmlControlBuilder WithOptions(params (string, string)[] options)
        {
            foreach (var option in options)
            {
                var li = new ListItem();
                li.Enabled = true;
                li.Value = option.Item1;
                li.Text = option.Item2;

                _options.Add(li);
            }
            return this;
        }

        public HtmlControlBuilder WithOption((string, string) option, bool isEnabled)
        {
            var li = new ListItem();
            li.Enabled = isEnabled;
            li.Value = option.Item1;
            li.Text = option.Item2;

            _options.Add(li);

            return this;
        }

        public override string ToString()
        {
            HtmlControl wc;

            switch (_type)
            {
                case HtmlControlType.TextInput:
                    wc = new HtmlInputText("text");
                    wc.ID = _propertyName;
                    wc.Attributes.Add("x-model", _propertyName);
                    break;
                case HtmlControlType.NumericInput:
                    wc = new HtmlInputText("number");
                    wc.Attributes.Add("x-model", _propertyName);
                    wc.ID = _propertyName;
                    break;
                case HtmlControlType.Select:
                    var select = new HtmlSelect();
                    select.ID = _propertyName;
                    select.Attributes.Add("x-model", _propertyName);
                    select.Items.AddRange(_options.ToArray());
                    wc = select;
                    break;
                default:
                    throw new ArgumentException();
            }

            if (_classes.Any())
            {
                wc.Attributes.Add("class", String.Join(" ", _classes));
            }

            var tr = new StringWriter();
            var writer = new HtmlTextWriter(tr);
            wc.RenderControl(writer);

            return tr.ToString();
        }
    }
}