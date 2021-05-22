using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace WebFormsWithAlpine.UI.Controls
{
    public class PageContractResolver : DefaultContractResolver
    {
        private readonly string _uniquePrefix;

        public PageContractResolver(string uniquePrefix)
        {
            _uniquePrefix = uniquePrefix;
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var prop = base.CreateProperty(member, memberSerialization);
            prop.PropertyName = _uniquePrefix + prop.PropertyName;
            return prop;
        }
    }
}