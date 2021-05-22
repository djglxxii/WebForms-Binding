using Newtonsoft.Json;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Serialization;
using WebFormsWithAlpine.Extensions;
using IValueProvider = System.Web.ModelBinding.IValueProvider;

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

    public class PageContractResolver : DefaultContractResolver
    {
        private readonly string _uniquePrefix;

        public PageContractResolver(Page page)
        {
            _uniquePrefix = page.GetUniquePrefix();
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var prop = base.CreateProperty(member, memberSerialization);
            prop.PropertyName = _uniquePrefix + prop.PropertyName;
            return prop;
        }
    }
}
