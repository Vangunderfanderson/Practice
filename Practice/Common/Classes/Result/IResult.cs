namespace Classes.Result
{
    public interface IResult<T>
    {
        bool Succeeded { get; }

        T Value { get; }

        string ErrorMessage { get; }
    }
}
