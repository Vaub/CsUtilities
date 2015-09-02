using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities.Option
{
    /// <summary>
    /// Options is a simple extension class to emulate a maybe behavior on C# types.
    /// It mainly tries to emulate Java Optional behavior.
    /// </summary>
    public static class Option
    {
        public static bool IsPresent<T>(this T value) => value != null;
        public static void IfPresent<T>(this T value, Action<T> func)
        {
            if (!value.IsPresent())
            {
                return;
            }

            func(value);
        }

        public static A Map<T, A>(this T value, Func<T, A> mapFunc) => value.IsPresent() ? mapFunc(value) : default(A);
        public static T Filter<T>(this T value, Func<T, bool> filterFunc) => value.IsPresent() && filterFunc(value) ? value : default(T);

        public static T Get<T>(this T value) => value.OrElseThrow(new ValueNotPresentException());
        public static T OrElse<T>(this T value, T defaultValue) => value.IsPresent() ? value : defaultValue;
        public static T OrElseGet<T>(this T value, Func<T> defaultValue) => value.IsPresent() ? value : defaultValue();
        public static T OrElseThrow<T>(this T value, Exception exception)
        {
            if (!value.IsPresent())
            {
                throw exception;
            }

            return value;
        }
    }
}
