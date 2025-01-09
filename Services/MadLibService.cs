
using System.Threading.Tasks;

namespace FiveToSeven___Endpoints.Services
{
    public class MadLibService
    {
            private List<string> _nouns;
            private List<string> _adjectives;

            public MadLibService()
            {
                _nouns = new List<string>();
                _adjectives = new List<string>();
            }
            public void AddNoun(string noun)
            {
                _nouns.Add(noun);
            }

            public void AddAdjective(string adjective)
            {
                _adjectives.Add(adjective);
            }
            public string UserStory()
            {

                if (_nouns.Count < 5 || _adjectives.Count < 5)
                {
                    return "Please provide exactly 5 nouns and 5 adjectives.";
                }
                string story = $"Once upon a time, there was a {_adjectives[0]} {_nouns[0]} who loved to eat. " +
                               $"It went on an food adventure with its {_adjectives[1]} {_nouns[1]} and met a {_adjectives[2]} {_nouns[2]}. " +
                               $"The {_adjectives[3]} {_nouns[3]} was very friendly and helped the group find a {_adjectives[4]} {_nouns[4]}. " +
                               $"They all had a great meal.";

                return story;
            }
        }
    }

