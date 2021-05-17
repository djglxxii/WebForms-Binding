using System;
using System.Web.ModelBinding;

namespace WebFormsWithAlpine.Controls
{
    public class ModelFormValueProvider<T> : IValueProvider where T : class, new()
    {
        private readonly Type _modelType;
        private readonly ModelBindingExecutionContext _context;
        private readonly string _uniqueId;

        public ModelFormValueProvider(PageWithModel<T> page)
        {
            _modelType = page.Model.GetType();
            _context = page.ModelBindingExecutionContext;
        }
        
        public bool ContainsPrefix(string prefix)
        {
            return true;
        }

        public ValueProviderResult GetValue(string key)
        {
            return null;
        }
    }
}