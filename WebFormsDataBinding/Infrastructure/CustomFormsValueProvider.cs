using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web.ModelBinding;

namespace WebFormsDataBinding.Infrastructure
{
    /// <summary>
    /// Custom FormsValueProvider that supports WebForms with a MasterPage.
    /// </summary>
    public class CustomFormsValueProvider : IValueProvider
    {
        private readonly NameValueCollection _form;

        public CustomFormsValueProvider(ModelBindingExecutionContext context)
        {
            _form = context.HttpContext.Request.Form;
        }

        public bool ContainsPrefix(string prefix)
        {
            return true;
        }

        public ValueProviderResult GetValue(string key)
        {
            if (string.IsNullOrEmpty(key)) return null;

            // due to the masterPage, form keys will be prefixed with a bunch of crap. 
            // Just look for the formkey that ends with the key passed in.
            var formKey = _form.AllKeys.SingleOrDefault(k => k.EndsWith(key));
            var value = _form[formKey];

            return new ValueProviderResult(value, value, CultureInfo.InvariantCulture);
        }
    }
}
