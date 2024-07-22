using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {

        public static Destination HighestDuration(List<Destination> destinations)
        {
            return destinations.OrderByDescending(a => DurationinMin(a.Duration)).FirstOrDefault();
        }
        private static int DurationinMin(string Duration)
        {
            if (string.IsNullOrWhiteSpace(Duration))
            {
                return 0; 
            }
            if (int.TryParse(Duration.Split(" ")[0], out int minutes))
            {
                return minutes;
            }
            return 0;
        }
    }
}
