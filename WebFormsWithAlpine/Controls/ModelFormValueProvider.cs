using System;
using System.Globalization;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;

namespace WebFormsWithAlpine.Controls
{
    public class ModelFormValueProvider<T> : IValueProvider where T : class, new()
    {
        private readonly Type _modelType;
        private readonly ModelBindingExecutionContext _context;
        private readonly string _uniquePrefix;

        public ModelFormValueProvider(PageWithModel<T> page)
        {
            var p = page.Parent;
            _modelType = page.Model.GetType();
            _context = page.ModelBindingExecutionContext;
            _uniquePrefix = GetUniquePrefix(page);
        }
        
        public bool ContainsPrefix(string prefix)
        {
            return true;
        }

        public ValueProviderResult GetValue(string key)
        {
            if (String.IsNullOrEmpty(key)) return null;

            var uniqueKey = $"{_uniquePrefix}{key}";
            var form = _context.HttpContext.Request.Form;
            var value = form[uniqueKey];

            return new ValueProviderResult(
                rawValue: value,
                attemptedValue: value ?? string.Empty,
                culture: CultureInfo.InvariantCulture);
        }

        private static string GetUniquePrefix(PageWithModel<T> page)
        {
            var form = page.Form;
            // TODO this will obviously fail if there are multiple ContentPlaceHolders.
            // add support for specifying which is the 'main' ContentPlaceHolder.
            var cp = form.Controls.OfType<ContentPlaceHolder>().Single();

            return cp.UniqueID + page.IdSeparator;
        }
    }
}