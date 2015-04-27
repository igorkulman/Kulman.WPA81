using System;

namespace Kulman.WPA81.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class PerRequestAttribute : Attribute
    {
    }
}
