namespace BLL.Interfaces
{
    public interface IService<T>
    {
        public void Add(T item);
        public void Update(T item);
        public void DeleteById(int id);
        public void Delete(T item);
        public T FindById(int id);
        public List<T> GetAll();
    }
}
