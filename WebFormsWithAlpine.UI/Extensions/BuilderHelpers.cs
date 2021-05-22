using System;
using System.Linq.Expressions;
using WebFormsWithAlpine.UI.Controls;

namespace WebFormsWithAlpine.UI.Extensions
{
    public static class BuilderHelpers
    {
        public static HtmlTextInputBuilder TextInputFor<TModel>(this PageWithModel<TModel> page,
            Expression<Func<TModel, string>> expr) where TModel : class, new()
        {
            return new HtmlTextInputBuilder(page, GetPropertyName(expr));
        }

        public static HtmlNumberInputBuilder NumberInputFor<TModel>(this PageWithModel<TModel> page,
            Expression<Func<TModel, string>> expr) where TModel : class, new()
        {
            return new HtmlNumberInputBuilder(page, GetPropertyName(expr));
        }

        public static HtmlSelectBuilder SelectFor<TModel>(this PageWithModel<TModel> page,
            Expression<Func<TModel, string>> expr) where TModel : class, new()
        {
            return new HtmlSelectBuilder(page, GetPropertyName(expr));
        }

        private static string GetPropertyName<TModel, TProperty>(Expression<Func<TModel, TProperty>> expr)
        {
            var expression = (MemberExpression)expr.Body;
            string propName = expression.Member.Name;
            return propName;
        }
    }
}
