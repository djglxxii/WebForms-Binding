using Newtonsoft.Json;
using System;
using System.IO;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Newtonsoft.Json.Serialization;
using IValueProvider = System.Web.ModelBinding.IValueProvider;

namespace WebFormsWithAlpine.Controls
{
    public abstract class PageWithModel<TModel> : Page where TModel : class, new()
    {
        public TModel Model { get; set; } = new TModel();

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
        }

        protected abstract void LoadData();

        protected virtual bool TryUpdateModel()
        {
            var provider = GetModelValueProvider();
            return TryUpdateModel(Model, provider);
        }

        protected virtual IValueProvider GetModelValueProvider()
        {
            return new PageValueProvider<TModel>(this);
        }

        public virtual string GetData()
        {
            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new PageContractResolver(this);
            var json = JsonConvert.SerializeObject(Model, settings);
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
