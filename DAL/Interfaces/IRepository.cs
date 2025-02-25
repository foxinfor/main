namespace DAL.Interfaces
{
    public interface IRepository<T>
    {
        public void Add(T entity);

        public void Update(T entity);

        public void Delete(T entity);

        public T Get(int id);

        public IEnumerable<T> GetAll();
    }
}
