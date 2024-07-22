using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class FilterDestinations
    {
        public static List<Destination> LessThan100(List<Destination> destinations)
        {
            return destinations
                .Where(a=> IsLessThan100(a.Duration))
                .ToList();
        }
        private static bool IsLessThan100(string Duration)
        {
            if (string.IsNullOrEmpty(Duration))
            {
                return false;
            }
            if (int.TryParse(Duration.Split(" ")[0], out int minutes))
            {
                return minutes < 100;
            }
            else
                return false;
        }
    }
}
