using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public Context Context;
        public UnitOfWork(Context _Context)
        {
            Context = _Context;

            AdminRepository = new AdminRepository(Context);

            ApplicationUserRepository = new ApplicationUserRepository(Context);

            CartRepository = new CartRepository(Context);

            CategoryRepository = new CategoryRepository(Context);

            OrderRepository = new OrderRepository(Context);

            OrderStatusRepository = new OrderStatusRepository(Context);

            ProductCartRepository = new ProductCartRepository(Context);

            ProductOrderRepository = new ProductOrderRepository(Context);

            ProductRepository = new ProductRepository(Context);

            ReturnOrderRepository  = new ReturnOrderRepository(Context);

            ReturnProductOrderRepository = new ReturnProductOrderRepository(Context);

            SubCategoryRepository = new SubCategoryRepository(Context);

            UserRepository = new UserRepository(Context);
        }

        public IAdminRepository AdminRepository { get; set; }

        public IApplicationUserRepository ApplicationUserRepository { get; set; }

        public ICartRepository CartRepository { get; set; }

        public ICategoryRepository CategoryRepository { get; set; }

        public IOrderRepository OrderRepository { get; set; }

        public IOrderStatusRepository OrderStatusRepository { get; set; }

        public IProductCartRepository ProductCartRepository { get; set; }

        public IProductOrderRepository ProductOrderRepository { get; set; }

        public IProductRepository ProductRepository { get; set; }

        public IReturnOrderRepository ReturnOrderRepository { get; set; }

        public IReturnProductOrderRepository ReturnProductOrderRepository { get; set; }

        public ISubCategoryRepository SubCategoryRepository { get; set; }

        public IUserRepository UserRepository { get; set; }

        public int CommitChanges()
        {
            return Context.SaveChanges();
        }
    }
}

