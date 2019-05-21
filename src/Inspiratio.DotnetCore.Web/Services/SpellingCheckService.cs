using System.Collections.Generic;

namespace Inspiratio.DotnetCore.Web.Services
{
    public class SpellingCheckService : ISpellingCheckService
    {
        private readonly List<string> badWords = new List<string>()
        {
            "Lucas",
            "Maravilhoso",
            "Java",
            "Linux",
            "Windows"
        };

        public string GetFriendlyMessage(string message)
        {
            return (badWords.Contains(message)) ? "***" : message;
        }
    }
}
