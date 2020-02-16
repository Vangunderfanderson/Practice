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
