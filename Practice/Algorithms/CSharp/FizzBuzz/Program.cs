using Classes;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new ConsoleMessageWriter();
            var fizzBuzz = new FizzBuzz(writer);
            fizzBuzz.Run(1, 100);
        }
    }
}
