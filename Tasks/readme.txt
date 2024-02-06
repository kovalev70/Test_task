// Добавив ограничение типа where T : new() 
// мы гарантируем, что передаваемый тип T содержит конструктор по умолчанию
class Instantiator<T> where T : new()
{
    public T instance;
    public Instantiator()
    {
        instance = new T();
    }
}


Либо мы можем внедрить зависимость и передать в конструктор экземпляр объекта T
class Instantiator<T>
{
    public T instance;
    public Instantiator(T obj)
    {
        instance = obj;
    }
}