using System;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using WebFormsWithAlpine.Controls;

namespace WebFormsWithAlpine.Extensions
{
    public static class WebControlExtensions
    {
        public static HtmlControlBuilder TextInputFor<T>(this PageWithModel<T> page, 
            Expression<Func<T, string>> expr) where T : class, new()
        {
            var expression = (MemberExpression) expr.Body;
            string propName = expression.Member.Name;

            return new HtmlControlBuilder(page, HtmlControlType.TextInput, propName);
        }

        public static HtmlControlBuilder NumberInputFor<T>(this PageWithModel<T> page,
            Expression<Func<T, int>> expr) where T : class, new()
        {
            var expression = (MemberExpression)expr.Body;
            string propName = expression.Member.Name;

            return new HtmlControlBuilder(page, HtmlControlType.NumericInput, propName);
        }
    }

    public class HtmlControlBuilder
    {
        private readonly Page _page;
        private readonly HtmlControlType _type;
        private readonly string _propertyName;
        private string _cssClass = null;

        public HtmlControlBuilder(Page page, HtmlControlType type, string propertyName)
        {
            _page = page;
            _type = type;
            _propertyName = propertyName;
        }

        public HtmlControlBuilder WithClass(string cssClass)
        {
            _cssClass = cssClass;
            return this;
        }
        
        public string Build()
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
                    wc = new HtmlSelect();
                    wc.ID = _propertyName;
                    wc.Attributes.Add("x-model", _propertyName);
                    break;
                default:
                    throw new ArgumentException();
            }

            if (!String.IsNullOrEmpty(_cssClass))
            {
                wc.Attributes.Add("class", _cssClass);
            }
            
            var tr = new StringWriter();
            var writer = new HtmlTextWriter(tr); 
            wc.RenderControl(writer);

            return tr.ToString();
        }
    }

    public enum HtmlControlType
    {
        TextInput,
        NumericInput,
        Select
    }
}