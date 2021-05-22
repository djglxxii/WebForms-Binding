using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using IValueProvider = System.Web.ModelBinding.IValueProvider;

namespace WebFormsWithAlpine.UI.Controls
{
    public abstract class PageWithModel<TModel> : Page, IHaveModel where TModel : class, new()
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
            var phs = this.Form.Controls.OfType<ContentPlaceHolder>().ToList();
            if (phs.Count > 1)
            {
                // TODO add support to target a specific ContentPlaceHolder.
                throw new InvalidOperationException(
                    "Pages with multiple ContentPlaceHolder controls is currently not supported.");
            }

            var cph = phs.Single();
            return cph.UniqueID + this.IdSeparator;
        }

        public override void RenderControl(HtmlTextWriter writer)
        {
            HtmlForm form = this.Page.Form;
            form.Attributes.Add("x-data", GetData());
            base.RenderControl(writer);
        }
    }
}
