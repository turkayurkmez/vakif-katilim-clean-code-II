namespace CleanCode.Library
{
    public interface IRepository<T> where T : class, IEntity
    {
        IList<T> GetAll();
    }
}
