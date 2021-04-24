using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebFormsWithAlpine.Pages;

namespace WebFormsWithAlpine.Infrastructure
{
    public class CustomFormValueProvider<T> : IValueProvider where T : class, new()
    {
        private readonly ModelBindingExecutionContext _context;
        private readonly string _uniqueId;
        private readonly char _separator;

        public CustomFormValueProvider(AbstractPage<T> page)
        {
            _context = page.ModelBindingExecutionContext;
            _uniqueId = FindUniqueId(page);
            _separator = page.IdSeparator;
        }

        public bool ContainsPrefix(string prefix)
        {
            return true;
            return prefix == "key" || prefix == "value";
        }

        public ValueProviderResult GetValue(string key)
        {
            if (String.IsNullOrEmpty(key)) return null;

            NameValueCollection form = _context.HttpContext.Request.Form;
            string prefixedKey = $"{_uniqueId}{_separator}{key}";

            string val = form[prefixedKey];
            
            return new ValueProviderResult(val, val ?? string.Empty, CultureInfo.InvariantCulture);
        }

        private static string FindUniqueId(AbstractPage<T> page)
        {
            var mp = page.Controls.OfType<MasterPage>().FirstOrDefault();
            if (mp != null)
            {
                var form = mp.Controls.OfType<HtmlForm>().Single();
                var ph = form.Controls.OfType<ContentPlaceHolder>().First();
                return ph.UniqueID;
            }

            throw new Exception("Unable to find unique id");
        }
    }
}