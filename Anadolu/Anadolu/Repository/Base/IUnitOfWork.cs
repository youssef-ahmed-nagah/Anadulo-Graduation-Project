using Anadolu.Models;

namespace Anadolu.Repository.Base
{
    public interface IUnitOfWork
    {
        IAdminRepository AdminRepository { get; set; }
        IApplicationUserRepository ApplicationUserRepository { get; set; }
        ICartRepository CartRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
        IOrderRepository OrderRepository { get; set; }
        IOrderStatusRepository OrderStatusRepository { get; set; }
        IProductCartRepository ProductCartRepository { get; set; }
        IProductOrderRepository ProductOrderRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        IReturnOrderRepository ReturnOrderRepository { get; set; }
        IReturnProductOrderRepository ReturnProductOrderRepository { get; set; }
        ISubCategoryRepository SubCategoryRepository { get; set; }
        IUserRepository UserRepository { get; set; }

        int CommitChanges();
    }
}


        //IRepository<Song> SongRepository { get; set; }

        //IRepository<Artist> GetArtistRepository();
        //void SetArtistRepository(IRepository<Artist> value);