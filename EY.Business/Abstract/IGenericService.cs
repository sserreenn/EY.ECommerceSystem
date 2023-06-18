namespace EY.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {

        void TInsert(T t);
        void TUpdate(T t);
        List<T> TGetAll();
        T TGetByID(int id);
    }
}
