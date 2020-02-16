using LanguageExt;

namespace Classes.Result
{
    /// <summary>
    ///     Factory to instantiate IResult
    /// </summary>
    public static class Result
    {
        public static IResult<T> Success<T> (T value)
            => new Result<T>(true, value, string.Empty);

        public static IResult<T> Fail<T>()
            => new Result<T>(false, default, string.Empty);

        public static IResult<T> Fail<T>(string errorMessage)
            => new Result<T>(false, default, errorMessage);

        public static IResult<Unit> Success()
            => new Result<Unit>(true, Unit.Default, string.Empty);

        public static IResult<Unit> Fail()
            => new Result<Unit>(false, Unit.Default, string.Empty);

        public static IResult<Unit> Fail(string errorMessage)
            => new Result<Unit>(false, Unit.Default, errorMessage);        
    }

    /// <summary>
    ///     Structure that represent the result of any function.
    ///     Allowing to check if the function succeeded or not and 
    ///     to propagate an error message in case it needs to be logged
    /// </summary>
    internal struct Result<T> : IResult<T>
    {
        public bool Succeeded { get; }

        public T Value { get; }

        public string ErrorMessage { get; }

        public Result(bool succeeded, T value, string errorMessage)
        {
            Succeeded = succeeded;
            Value = value;
            ErrorMessage = errorMessage;
        }
    }
}
