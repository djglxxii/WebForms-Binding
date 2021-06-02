using System;
using System.Linq;
using System.Reflection;
using System.Web.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebFormsWithAlpine.Extensions;

namespace WebFormsWithAlpine.Controls
{
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

            var att = member.GetCustomAttribute<RequiresUniqueIdPrefix>();
            if (att != null)
            {
                prop.PropertyName = _uniquePrefix + prop.PropertyName;
            }
            
            return prop;
        }
    }

    /// <summary>
    /// Marker attribute for json serialization process.
    /// </summary>
    public class RequiresUniqueIdPrefix : Attribute
    {

    }
}