using System;
using System.Linq.Expressions;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using WebFormsWithAlpine.Controls;

namespace WebFormsWithAlpine.Extensions
{
    public static class WebControlExtensions
    {
        public static HtmlControlBuilder TextInputFor<T>(this PageWithModel<T> page, 
            Expression<Func<T, object>> expr) where T : class, new()
        {
            var expression = (MemberExpression) expr.Body;
            string propName = expression.Member.Name;

            return new HtmlControlBuilder(page, HtmlControlType.TextInput, propName);
        }
    }

    public class HtmlControlBuilder
    {
        private readonly HtmlControlType _type;
        private readonly string _propertyName;

        public HtmlControlBuilder(Page page, HtmlControlType type, string propertyName)
        {
            _type = type;
            _propertyName = propertyName;
        }

        public HtmlControl Build()
        {
            HtmlControl wc;

            switch (_type)
            {
                case HtmlControlType.TextInput:
                    wc = new HtmlInputText("text");
                    wc.ID = _propertyName;
                    break;
                case HtmlControlType.NumericInput:
                    wc = new HtmlInputText("number");
                    wc.ID = _propertyName;
                    break;
                case HtmlControlType.Select:
                    wc = new HtmlSelect();
                    wc.ID = _propertyName;
                    break;
                default:
                    throw new ArgumentException();
            }

            return wc;
        }
    }

    public enum HtmlControlType
    {
        TextInput,
        NumericInput,
        Select
    }
}