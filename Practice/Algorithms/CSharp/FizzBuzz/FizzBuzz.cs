using Classes;
using System;
using Utility;

namespace FizzBuzz
{
    /// <summary>
    ///     Basic algorithm that for a sequence of numbers prints: 
    ///      - "Fizz" (number divisible by 3)
    ///      - "Buzz" (number divisible by 5)
    ///      - "FizzBuzz" (number divisible by both 3 and 5)
    ///      - The number itself (if the number is not divisible by 3 or 5
    /// </summary>
    public class FizzBuzz
    {
        private readonly IMessageWriter _messageWriter;

        public FizzBuzz(IMessageWriter messageWriter)
        {
            _messageWriter = messageWriter ?? throw new ArgumentNullException("Message writer");
        }

        public void Run(int start, int end)
        {            
            for (int i = start; i <= end; i++)
            {
                var line = string.Empty;
                if (i % 3 == 0)
                    line += "Fizz";

                if (i % 5 == 0)
                    line += "Buzz";

                if (line.IsEmpty())
                    line += i.ToString();

                _messageWriter.WriteMessage(line);
            }

        }

    }
}
