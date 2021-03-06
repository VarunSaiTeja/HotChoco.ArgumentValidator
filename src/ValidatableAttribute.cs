using System;

namespace HotChoco.ArgumentValidator
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class ValidatableAttribute : Attribute
    {
        public ValidatableAttribute()
        {
        }
    }
}
