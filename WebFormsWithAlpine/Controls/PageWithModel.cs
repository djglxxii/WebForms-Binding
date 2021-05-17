using Newtonsoft.Json;
using System;
using System.Web.ModelBinding;
using System.Web.UI;

namespace WebFormsWithAlpine.Controls
{
    public abstract class PageWithModel<T> : Page where T : class, new()
    {
        public T Model { get; set; } = new T();

        protected virtual void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
            else
            {
                TryUpdateModel();
            }
            
            DataBind();
        }

        protected abstract void LoadData();

        protected virtual bool TryUpdateModel()
        {
            var provider = GetModelValueProvider();
            return TryUpdateModel(Model, provider);
        }

        protected virtual IValueProvider GetModelValueProvider()
        {
            return new ModelFormValueProvider<T>(this);
        }
        
        public virtual string GetData()
        {
            var json = JsonConvert.SerializeObject(Model);
            return json;
        }
    }
}
