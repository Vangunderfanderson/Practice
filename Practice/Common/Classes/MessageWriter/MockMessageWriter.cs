using System.Collections.Generic;
using Utility;

namespace Classes.MessageWriter
{
    /// <summary>
    ///     Class to mock a console writer. Only for testing purposes
    /// </summary>
    public class MockMessageWriter : IMessageWriter
    {
        public List<string> WrittenMessages { get; set; } = new List<string>();

        public void WriteMessage(string message)
        {
            if (message.IsNullOrEmpty())
                return;

            WrittenMessages.Add(message);
        }
    }
}
