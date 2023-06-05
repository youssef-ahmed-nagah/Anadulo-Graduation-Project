using Anadolu.Models;
using Anadolu.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Anadolu.Repository
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private readonly Context Context;
        public CartRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }

        public List<ProductCart> GetCartItemsById(string userid, Func<ProductCart, bool> predicate)
        {
            var cart = Context.Carts.Include(p => p.ProductCart).Where(c => c.UserId == userid)
                .FirstOrDefault();
            var cartItems = Context.ProductCarts.Include(p => p.Product).
                Where(p => p.CartId == cart.UserId).ToList();


            return cartItems;
        }
    }
}
