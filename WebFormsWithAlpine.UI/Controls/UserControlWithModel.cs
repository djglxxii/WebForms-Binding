using Newtonsoft.Json;
using System;
using System.Web.ModelBinding;
using System.Web.UI;

namespace WebFormsWithAlpine.UI.Controls
{
    public abstract class UserControlWithModel<TModel> : UserControl, IHaveModel<TModel> where TModel : class, new()
    {
        public TModel Model { get; protected set; } = new TModel();

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
            return new ModelFormValueProvider<TModel>(this);
        }

        public virtual string GetData()
        {
            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new PageContractResolver(this.GetUniquePrefix());
            var json = JsonConvert.SerializeObject(Model, settings);
            return json;
        }

        public string GetUniquePrefix()
        {
            return this.UniqueID + Page.IdSeparator;
        }

        public override void RenderControl(HtmlTextWriter writer)
        {
            writer.AddAttribute("x-data", GetData());
            writer.RenderBeginTag("div");
            base.RenderControl(writer);
            writer.RenderEndTag();
        }
    }
}
