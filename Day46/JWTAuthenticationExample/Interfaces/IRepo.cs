namespace JWTAuthenticationExample.Interfaces
{
    public interface IRepo<K,T> :IBaseRepo<K,T>
    {
        ICollection<T> GetAll();
        T Update(T item);
        T Delete(K key);
    }
}
