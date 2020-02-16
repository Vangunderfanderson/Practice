using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Result
{
    public static class ResultExtensions
    {
        public static T GetValueOrDefault<T>(this IResult<T> result)
            => result.Succeeded
                ? result.Value
                : default(T);
    }
}
