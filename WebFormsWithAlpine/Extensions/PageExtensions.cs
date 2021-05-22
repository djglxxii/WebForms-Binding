using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsWithAlpine.Controls;

namespace WebFormsWithAlpine.Extensions
{
    public static class PageExtensions
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

        public static string GetUniquePrefix(this Page page)
        {
            var cphs = page.Form.Controls.OfType<ContentPlaceHolder>().ToList();
            if (cphs.Count > 1)
            {
                // TODO add support to target a specific ContentPlaceHolder.
                throw new InvalidOperationException(
                    "Pages with multiple ContentPlaceHolder controls is currently not supported.");
            }

            var cph = cphs.Single();
            return cph.UniqueID + page.IdSeparator;
        }
    }

    public enum HtmlControlType
    {
        TextInput,
        NumericInput,
        Select
    }
}