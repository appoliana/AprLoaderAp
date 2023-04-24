using System;
using System.Threading.Tasks;

namespace AprLoader.Core
{
    public interface IBasicDbService<T> where T : class
    {
        event Action<object, Exception> ExceptionRaised;

        /// <summary>
        /// Получение объектов типа T массивом
        /// </summary>
        /// <returns></returns>
        T[] GetAsArray();

        /// <summary>
        /// Аснихронный вариант вызова GetAsArray()
        /// </summary>
        /// <returns></returns>
        Task<T[]> GetAsArrayAsync();

        /// <summary>
        /// Удаление объекта типа T из бд
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true если успех и false если ошибка, при этом срабатывает DBExceptionRaised</returns>
        bool Remove(T obj);

        /// <summary>
        /// Асинхронный вариант вызова Remove(T obj)
        /// </summary>
        /// <returns>true если успех и false если ошибка, при этом срабатывает DBExceptionRaised</returns>
        Task<bool> RemoveAsync(T obj);

        /// <summary>
        /// Добавление объекта типа T в БД
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true если успех и false если ошибка, при этом срабатывает DBExceptionRaised</returns>
        bool Add(T obj);

        /// <summary>
        /// Асинхронный вариант вызова Add(T obj)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true если успех и false если ошибка, при этом срабатывает DBExceptionRaised</returns>
        Task<bool> AddAsync(T obj);

        /// <summary>
        /// Находит элемент по PK и обновляет его согласно свойствам obj
        /// </summary>
        /// <param name="obj">Объект obj должен иметь существующий PK</param>
        /// <returns>true если успех и false если ошибка, при этом срабатывает DBExceptionRaised</returns>
        bool Update(T obj);

        /// <summary>
        /// Асинхронный вариант вызова T Update(T obj);
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true если успех и false если ошибка, при этом срабатывает DBExceptionRaised</returns>
        Task<bool> UpdateAsync(T obj);
    }
}
