namespace BLL.Interfaces
{
    public interface IService<T>
    {
        public void Add(T item);
        public void Update(T item);
        public void DeleteById(string id);
        public void Delete(T item);
        public List<T> GetAll();
    }
}
