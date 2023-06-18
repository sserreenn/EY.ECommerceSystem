using EY.Business.Abstract;
using EY.DataAccess.Abstruct;
using EY.Entities.Concrete;

namespace EY.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<User> TGetAll()
        {
           return _userDal.GetAll();
        }

        public User TGetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public void TInsert(User t)
        {
           _userDal.Insert(t);
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
