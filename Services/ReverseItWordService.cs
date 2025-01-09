using System.Threading.Tasks;

namespace FiveToSeven___Endpoints.Services
{
    public class ReverseItWordService
    {
        public string ReverseWord(string input)
        {

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
