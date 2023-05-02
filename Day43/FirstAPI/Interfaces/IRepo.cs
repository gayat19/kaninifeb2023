namespace FirstAPI.Interfaces
{
    public interface IRepo<K,T>
    {
        T Get(K key);
        ICollection<T> GetAll();
        T Add(T item);
        T Delete(K key);
        T Update(T item);
    }
}
