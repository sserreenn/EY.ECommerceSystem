namespace EY.DataAccess.Abstruct
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        List<T> GetAll();
        T GetByID(int id);
    }
}