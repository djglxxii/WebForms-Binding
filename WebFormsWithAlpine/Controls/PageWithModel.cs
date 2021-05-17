using System;
using System.Web.UI;
using Newtonsoft.Json;

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
                // formvalueprovider
            }
            
            DataBind();
        }

        protected abstract void LoadData();
        
        public virtual string GetData()
        {
            var json = JsonConvert.SerializeObject(Model);
            return json;
        }
    }
}
