using System;
using System.Globalization;
using System.Web.ModelBinding;
using WebFormsWithAlpine.Extensions;

namespace WebFormsWithAlpine.Controls
{
    public class PageValueProvider<T> : IValueProvider where T : class, new()
    {
        private readonly ModelBindingExecutionContext _context;
        private readonly string _uniquePrefix;

        public PageValueProvider(PageWithModel<T> page)
        {
            _context = page.ModelBindingExecutionContext;
            _uniquePrefix = page.GetUniquePrefix();
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
    }
}