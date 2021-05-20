using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

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
        
        public override void RenderControl(HtmlTextWriter writer)
        {
            HtmlForm form = this.Page.Form;
            form.Attributes.Add("x-data", GetData());
            base.RenderControl(writer);
        }
    }
}
