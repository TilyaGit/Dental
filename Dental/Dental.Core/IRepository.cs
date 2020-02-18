namespace Dental.Core
{
    public  interface IRepository <T> where T : class
    {
        void Add(T t);

        void Save(T t);

        void Delete(T t);
    }
}
