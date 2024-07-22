using MagicLandExplorer.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace MagicLandExplorer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filepath = "data.json";
            string json = File.ReadAllText(filepath);

            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            List<Destination> allDestinations = categories
                .SelectMany(c => c.Destinations)
                .ToList();
            while (true)
            {
                Console.WriteLine("[1] Destinations with a duration less than 100 minutes\n[2] Destination with the longest duration\n[3] Sort alphabetically\n[4] top three longest-duration destinations\n[5] Exit");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int ans))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                switch (ans)
                {
                    case 1:
                        var lessthan100 = FilterDestinations.LessThan100(allDestinations);
                        foreach (var destination in lessthan100)
                        {
                            Console.WriteLine($"{destination.Name}");
                        }
                        break;

                    case 2:
                        var longestduration = LongestDuration.HighestDuration(allDestinations);
                        if (longestduration != null)
                        {
                            Console.WriteLine($"{longestduration.Name}");
                        }
                        break;

                    case 3:
                        var sorted= SortByName.alphabeticalSorting(allDestinations);
                        foreach (var destination in sorted)
                        {
                            Console.WriteLine($"{destination.Name}");
                        }
                        break;
                    case 4:
                        var top3 = Top3Duration.Top3(allDestinations);
                        foreach (var destination in top3)
                        {
                            Console.WriteLine($"{destination.Name +" - "+ destination.Duration}");
                        }
                        break;

                    case 5:
                        return;

                }
            }
        }
    }
}
