using EY.DataAccess.Abstruct;
using EY.DataAccess.Concrete;
using EY.DataAccess.Repositories;
using EY.Entities.Concrete;

namespace EY.DataAccess.EntityFramework
{
    public class EFUserDal:GenericRepository<User>,IUserDal
    {
        public EFUserDal(Context context): base(context)
        {

        }
    }
}
