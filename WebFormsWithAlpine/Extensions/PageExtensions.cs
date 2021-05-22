using System;
using System.Linq.Expressions;
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
    }

    public enum HtmlControlType
    {
        TextInput,
        NumericInput,
        Select
    }
}