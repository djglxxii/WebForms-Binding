using System;

namespace WebFormsWithAlpine.Infrastructure
{
    /// <summary>Marker attribute indicating that property contains serialized json data.</summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class JsonDataAttribute : Attribute
    {
    }
}