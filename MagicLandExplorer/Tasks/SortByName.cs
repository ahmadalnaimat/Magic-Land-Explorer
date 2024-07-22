using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        public static List<Destination> alphabeticalSorting(List<Destination> destinations)
        {
            return destinations.OrderBy(a => a.Name).ToList();
        }
    }
}
