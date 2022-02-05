using HomeCine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeCine.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);

        Task<List<Order>> GetOerdersByUserIdAndRoleAsync(string UserId, string userRole);
    }
}
