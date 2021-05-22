using System.Reflection;
using System.Web.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebFormsWithAlpine.UI.Extensions;

namespace WebFormsWithAlpine.UI.Controls
{
    public class PageContractResolver : DefaultContractResolver
    {
        private readonly string _uniquePrefix;

        public PageContractResolver(Page page)
        {
            _uniquePrefix = page.GetUniquePrefix();
        }

        public PageContractResolver(UserControl uc)
        {
            _uniquePrefix = uc.GetUniquePrefix();
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var prop = base.CreateProperty(member, memberSerialization);
            prop.PropertyName = _uniquePrefix + prop.PropertyName;
            return prop;
        }
    }
}