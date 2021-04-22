using System.Collections.Generic;
using LocationData.Models;

namespace LocationData
{
    public interface ILocationRepository
    {
        IReadOnlyList<Location> RetrieveLocations();

        Location FetchLocation(int LocationID);

        Location GetLocation(string email);

        Location CreateLocation(string streetAddress, string city, string region, string zip);
    }
}
