using EY.DataAccess.Abstruct;
using EY.DataAccess.Concrete;
using EY.DataAccess.Repositories;
using EY.Entities.Concrete;

namespace EY.DataAccess.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public EFProductDal(Context context) : base(context)
        {
        }
    }
}
