// Task6
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


// Либо мы можем внедрить зависимость и передать в конструктор экземпляр объекта T
class Instantiator<T>
{
    public T instance;
    public Instantiator(T obj)
    {
        instance = obj;
    }
}


// Task9
// Количество всех студентов:

SELECT COUNT(id) AS total_students
FROM students;

// Количество студентов с именем "Иван":

SELECT COUNT(id) AS ivan_students
FROM students
WHERE name = 'Иван';

// Количество студентов, созданных после 1 сентября 2020 года:

SELECT COUNT(id) AS students_after_2020
FROM students
WHERE created_at > '2020-09-01';

// Максимальное количество детей у одного родителя:

SELECT MAX(child_count) AS max_children_count
FROM (
    SELECT parent_id, COUNT(id) AS child_count
    FROM students
    GROUP BY parent_id
) AS children_count_table;