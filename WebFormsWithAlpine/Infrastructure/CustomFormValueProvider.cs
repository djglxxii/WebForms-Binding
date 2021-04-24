using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebFormsWithAlpine.Pages;
using WebFormsWithAlpine.UserControls;

namespace WebFormsWithAlpine.Infrastructure
{
    public class CustomFormValueProvider<TModel> : IValueProvider where TModel : class, new()
    {
        private readonly ModelBindingExecutionContext _context;
        private readonly string _uniqueId;
        private readonly char _separator;
        private readonly Dictionary<string, PropertyInfo> _piMap 
            = new Dictionary<string, PropertyInfo>();

        private NameValueCollection Form => _context.HttpContext.Request.Form;

        public CustomFormValueProvider(AbstractPage<TModel> page)
            : this()
        {
            _context = page.ModelBindingExecutionContext;
            _uniqueId = FindUniqueId(page);
            _separator = page.IdSeparator;
        }

        public CustomFormValueProvider(AbstractControl<TModel> control)
            : this()
        {
            _context = control.Page.ModelBindingExecutionContext;
            _uniqueId = control.UniqueID;
            _separator = control.Page.IdSeparator;
        }

        private CustomFormValueProvider()
        {
            string tModelName = this.GetType().GetGenericArguments().First().FullName;
            var tModelType = Type.GetType(tModelName);
            var props = tModelType.GetProperties();
            foreach (var prop in props)
            {
                _piMap[prop.Name] = prop;
            }
        }

        public bool ContainsPrefix(string prefix)
        {
            return true;
        }

        public ValueProviderResult GetValue(string key)
        {
            if (String.IsNullOrEmpty(key)) return null;
            
            string prefixedKey = $"{_uniqueId}{_separator}{key}";
            string val = Form[prefixedKey];

            var prop = _piMap[key];
            if (prop.IsJsonSerialized())
            {
                return new ValueProviderResult(val, val ?? string.Empty, CultureInfo.InvariantCulture);
            }
            else
            {
                return new ValueProviderResult(val, val ?? string.Empty, CultureInfo.InvariantCulture);   
            }
        }

        private static string FindUniqueId(AbstractPage<TModel> page)
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