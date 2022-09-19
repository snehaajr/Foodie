using Models;

namespace Services
{
    public interface IRestaurantOwnerService
    {
        string PostRequest(RestaurantRequest r);
    }
}