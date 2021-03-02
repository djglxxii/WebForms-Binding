using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebForms.Infrastructure
{
    public static class PageHelpers
    {
        public static ControlBuilder TextBoxFor<T>(this Page page, Expression<Antlr.Runtime.Misc.Func<T, object>> expr) where T : class
        {
            var expression = (MemberExpression)expr.Body;
            string propName = expression.Member.Name;

            return new ControlBuilder(page, "textbox", propName);
        }

        private static string GetMemberName(Expression expression)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.MemberAccess:
                    return ((MemberExpression)expression).Member.Name;
                case ExpressionType.Convert:
                    return GetMemberName(((UnaryExpression)expression).Operand);
                default:
                    throw new NotSupportedException(expression.NodeType.ToString());
            }
        }
    }

    public class ControlBuilder
    {
        private readonly WebControl _webControl = new WebControl(HtmlTextWriterTag.Div);
        private readonly Page _page;
        private readonly string _inputType;
        private readonly string _propertyName;

        private string _labelText;
        private string _cssClass;

        public ControlBuilder(Page page, string inputType, string propertyName)
        {
            _page = page;
            _propertyName = propertyName;
        }

        public ControlBuilder WithLabel(string labelText)
        {
            _labelText = labelText;
            return this;
        }

        public ControlBuilder WithClass(string cssClass)
        {
            _cssClass = cssClass;
            return this;
        }

        public string Build()
        {
            var tb = new TextBox();
            tb.ID = this._propertyName;
            
            tb.CssClass = this._cssClass;

            this._webControl.Controls.Add(tb);

            var sb = new StringBuilder();
            var tw = new StringWriter(sb);
            var writer = new HtmlTextWriter(tw);

            _webControl.RenderControl(writer);

            var str = sb.ToString();

            
            
            return str;
        }
    }
}