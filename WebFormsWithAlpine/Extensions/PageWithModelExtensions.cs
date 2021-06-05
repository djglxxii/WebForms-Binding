using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsWithAlpine.Controls;

namespace WebFormsWithAlpine.Extensions
{
    public static class PageWithModelExtensions
    {
        public static HtmlControlBuilder TextInputFor<TModel>(this PageWithModel<TModel> page, 
            Expression<Func<TModel, string>> expr) where TModel : class, new()
        {
            return new HtmlControlBuilder(page, HtmlControlType.TextInput, GetPropertyName(expr));
        }

        public static HtmlControlBuilder NumberInputFor<TModel>(this PageWithModel<TModel> page,
            Expression<Func<TModel, int>> expr) where TModel : class, new()
        {
            return new HtmlControlBuilder(page, HtmlControlType.NumericInput, GetPropertyName(expr));
        }

        public static HtmlControlBuilder SelectFor<TModel>(this PageWithModel<TModel> page,
            Expression<Func<TModel, string>> expr) where TModel : class, new()
        {
            return new HtmlControlBuilder(page, HtmlControlType.Select, GetPropertyName(expr));
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

        private static string GetPropertyName<TModel, TProperty>(Expression<Func<TModel, TProperty>> expr)
        {
            var expression = (MemberExpression)expr.Body;
            string propName = expression.Member.Name;
            return propName;
        }
    }

    public enum HtmlControlType
    {
        TextInput,
        NumericInput,
        Select
    }
}